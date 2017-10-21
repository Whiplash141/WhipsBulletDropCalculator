namespace WhipsBulletDropCalculator
{
    partial class Popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup));
            this.pictureBoxPopup = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopup)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPopup
            // 
            this.pictureBoxPopup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPopup.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxPopup.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxPopup.Name = "pictureBoxPopup";
            this.pictureBoxPopup.Size = new System.Drawing.Size(680, 680);
            this.pictureBoxPopup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPopup.TabIndex = 0;
            this.pictureBoxPopup.TabStop = false;
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 701);
            this.Controls.Add(this.pictureBoxPopup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Popup";
            this.Text = "Enlarged Image";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPopup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPopup;
    }
}