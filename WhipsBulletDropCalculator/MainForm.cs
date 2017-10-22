using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace WhipsBulletDropCalculator
{
    public partial class BulletDropForm : Form
    {
        string version = "v0.0.2";
        string date = "10/21/17";
        int centerX = 720;
        int centerY = 725;
        float mildotSpacing = 22.5f;
        Color aimpointColor = Color.FromArgb(0, 255, 0);

        float timeToSimulate = 8f;
        float timeStep = 0.0001f; // seconds
        float gravity = 9.81f; // m/s/s
        float muzzleVelocity; // m/s
        float zeroingRange;// m
        float targetRange; // m
        float dragForce;
        float mildots;
        
        List<Vector2> positionList = new List<Vector2>();
        List<Vector2> rotatedPositionList = new List<Vector2>();

        public BulletDropForm()
        {
            InitializeComponent();
            this.Text = $"Whip's Bullet Drop Calculator ({version} - {date})";
        }

        public void InitializeValues()
        {
            targetRange = (float)numericUpDownRange.Value;
            zeroingRange = (float)numericUpDownZero.Value;
            muzzleVelocity = (float)numericUpDownBulletSpeed.Value;
            dragForce = (float)numericUpDownDragForce.Value;
            positionList.Clear();
            rotatedPositionList.Clear();
        }

        public void DoMath()
        {
            //Initial simulation
            var velocityVector = new Vector2(muzzleVelocity, 0);
            var positionVector = new Vector2(0, 0);
            positionList.Add(positionVector);

            for (float t = 0; t <= timeToSimulate; t += timeStep)
            {
                var frictionAcceleration = dragForce * velocityVector.LengthSquared();

                //compute total acceleration on the bullet
                var accelerationVector = -Vector2.Normalize(velocityVector) * frictionAcceleration + new Vector2(0, -gravity);


                //d = 1/2*a*t^2 + vi*t + d0;
                positionVector += velocityVector * timeStep + 1 / 2 * accelerationVector * timeStep * timeStep;
                positionList.Add(positionVector);

                //vf = vi + at
                velocityVector += accelerationVector * timeStep;
            }

            //Solve for zeroing position
            Vector2 zeroingPosition = new Vector2(0, 0);
            float smallestDistance = 100000;
            for (int i = 0; i < positionList.Count; i++)
            {
                var thisPos = positionList[i];

                var distanceFromOrigin = thisPos != Vector2.Zero ? thisPos.Length() : 0f;

                var thisDistance = Math.Abs(distanceFromOrigin - zeroingRange);

                if (thisDistance < smallestDistance)
                {
                    zeroingPosition = thisPos;
                    smallestDistance = thisDistance;
                }
            }

            //Get elevation angle for zeroing
            var zeroingElevationAngle = zeroingPosition != Vector2.Zero  ?Math.Atan(zeroingPosition.Y / -zeroingPosition.X) : 0.0;
            var cos = (float)Math.Cos(zeroingElevationAngle);
            var sin = (float)Math.Sin(zeroingElevationAngle);

            //Create rotation matrix (matricies are transposed from math conventions)
            var rotationMatrix = new Matrix3x2();
            rotationMatrix.M11 = cos;
            rotationMatrix.M12 = sin;
            rotationMatrix.M21 = -sin;
            rotationMatrix.M22 = cos;

            //Rotate all of our values
            for (int i = 0; i < positionList.Count; i++)
            {
                rotatedPositionList.Add(Vector2.TransformNormal(positionList[i], rotationMatrix));
            }

            //Solve for desired range
            var targetPos = new Vector2(0, 0);
            smallestDistance = 100000;
            for (int i = 0; i < rotatedPositionList.Count; i++)
            {
                var thisPos = rotatedPositionList[i];

                var thisDistance = Math.Abs(thisPos.X - targetRange);

                if (thisDistance < smallestDistance)
                {
                    targetPos = thisPos;
                    smallestDistance = thisDistance;
                }
            }

            mildots = -targetPos.Y / targetPos.X * 1000f;
            string direction = mildots > 0 ? "above" : "below";

            textBoxMildot.Text = $"Aim {Math.Abs(mildots):N2} mildots {direction} target";
        }

        public void ImageProcessing()
        {
            Bitmap image = new Bitmap(Properties.Resources.reticle_clean);
            int offset = (int)Math.Round(mildotSpacing * mildots);
            for (int i = -50; i <= 50; i++)
            {
                for (int j = -2; j <= 2; j++)
                { 
                    SetPixelSafe(image, centerX + i, centerY + offset + j, aimpointColor);
                }
            }
            pictureBoxScope.Image = image;
        }

        public void SetPixelSafe(Bitmap image, int x, int y, Color color)
        {
            if (x > 0 && x <= image.Width && y > 0 && y <= image.Height)
                image.SetPixel(x, y, color);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            InitializeValues();
            DoMath();
            ImageProcessing();
        }

        Popup popupForm;
        private void pictureBoxScope_Click(object sender, EventArgs e)
        {
            if (popupForm != null)
                popupForm.Dispose();

            popupForm = new Popup(pictureBoxScope.Image);
            popupForm.Show();
        }
    }
}
