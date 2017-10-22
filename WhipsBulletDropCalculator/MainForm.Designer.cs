namespace WhipsBulletDropCalculator
{
    partial class BulletDropForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulletDropForm));
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.numericUpDownRange = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownZero = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownBulletSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownDragForce = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMildot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxScope = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTipMaster = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBulletSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDragForce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScope)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculate.Location = new System.Drawing.Point(58, 270);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(89, 40);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.toolTipMaster.SetToolTip(this.buttonCalculate, "Calculate mildot adjustment");
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // numericUpDownRange
            // 
            this.numericUpDownRange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownRange.Location = new System.Drawing.Point(47, 69);
            this.numericUpDownRange.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRange.Name = "numericUpDownRange";
            this.numericUpDownRange.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRange.TabIndex = 1;
            this.numericUpDownRange.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownZero
            // 
            this.numericUpDownZero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownZero.Location = new System.Drawing.Point(47, 126);
            this.numericUpDownZero.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownZero.Name = "numericUpDownZero";
            this.numericUpDownZero.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownZero.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Range to Target (m)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zeroing Range (m)";
            // 
            // numericUpDownBulletSpeed
            // 
            this.numericUpDownBulletSpeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownBulletSpeed.Location = new System.Drawing.Point(47, 180);
            this.numericUpDownBulletSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownBulletSpeed.Name = "numericUpDownBulletSpeed";
            this.numericUpDownBulletSpeed.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownBulletSpeed.TabIndex = 5;
            this.numericUpDownBulletSpeed.Value = new decimal(new int[] {
            1060,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Muzzle Velocity (m/s)";
            // 
            // numericUpDownDragForce
            // 
            this.numericUpDownDragForce.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownDragForce.DecimalPlaces = 6;
            this.numericUpDownDragForce.Location = new System.Drawing.Point(47, 233);
            this.numericUpDownDragForce.Name = "numericUpDownDragForce";
            this.numericUpDownDragForce.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDragForce.TabIndex = 7;
            this.numericUpDownDragForce.Value = new decimal(new int[] {
            38,
            0,
            0,
            327680});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Drag Force (N)";
            // 
            // textBoxMildot
            // 
            this.textBoxMildot.Location = new System.Drawing.Point(26, 392);
            this.textBoxMildot.Name = "textBoxMildot";
            this.textBoxMildot.ReadOnly = true;
            this.textBoxMildot.Size = new System.Drawing.Size(238, 22);
            this.textBoxMildot.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Inputs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mildot adjustment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 528);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 51);
            this.label8.TabIndex = 14;
            this.label8.Text = "Bullet Drop Converter\r\nAuthor: Whiplash141\r\nRequested by: Scav";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Output";
            // 
            // pictureBoxScope
            // 
            this.pictureBoxScope.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxScope.Image = global::WhipsBulletDropCalculator.Properties.Resources.reticle_clean;
            this.pictureBoxScope.Location = new System.Drawing.Point(279, 9);
            this.pictureBoxScope.Name = "pictureBoxScope";
            this.pictureBoxScope.Size = new System.Drawing.Size(570, 570);
            this.pictureBoxScope.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScope.TabIndex = 13;
            this.pictureBoxScope.TabStop = false;
            this.toolTipMaster.SetToolTip(this.pictureBoxScope, "Enlarge image");
            this.pictureBoxScope.Click += new System.EventHandler(this.pictureBoxScope_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(483, 582);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "(Click image to enlarge)";
            // 
            // BulletDropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 616);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBoxScope);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMildot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownDragForce);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownBulletSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownZero);
            this.Controls.Add(this.numericUpDownRange);
            this.Controls.Add(this.buttonCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BulletDropForm";
            this.Text = "Whip\'s Bullet Drop Calculator ({VERSION})";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBulletSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDragForce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScope)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.NumericUpDown numericUpDownRange;
        private System.Windows.Forms.NumericUpDown numericUpDownZero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownBulletSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownDragForce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMildot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxScope;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTipMaster;
    }
}

