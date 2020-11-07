namespace PICKTrainingInc
{
    partial class SplashPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashPage));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.sloganLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(18, 14);
            this.Logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(322, 328);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // sloganLabel
            // 
            this.sloganLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sloganLabel.Location = new System.Drawing.Point(366, 194);
            this.sloganLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(669, 117);
            this.sloganLabel.TabIndex = 1;
            this.sloganLabel.Text = "Skip the classroom and\r\n train from anywhere in the world with an \r\nLMS for the m" +
    "odern workforce.\r\n";
            this.sloganLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sloganLabel2
            // 
            this.sloganLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sloganLabel2.AutoSize = true;
            this.sloganLabel2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sloganLabel2.Location = new System.Drawing.Point(366, 74);
            this.sloganLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sloganLabel2.Name = "sloganLabel2";
            this.sloganLabel2.Size = new System.Drawing.Size(588, 44);
            this.sloganLabel2.TabIndex = 2;
            this.sloganLabel2.Text = "Easily Train Your Remote Team\r\n";
            // 
            // SplashPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 366);
            this.Controls.Add(this.sloganLabel2);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SplashPage";
            this.Text = "PICK Training Inc.";
            this.Load += new System.EventHandler(this.SplashPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label sloganLabel;
        private System.Windows.Forms.Label sloganLabel2;
    }
}

