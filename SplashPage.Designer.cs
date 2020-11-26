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
            this.goback_btn1 = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(12, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(215, 213);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // sloganLabel
            // 
            this.sloganLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sloganLabel.ForeColor = System.Drawing.Color.Coral;
            this.sloganLabel.Location = new System.Drawing.Point(283, 90);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(455, 90);
            this.sloganLabel.TabIndex = 1;
            this.sloganLabel.Text = "Skip the classroom and\r\n train from anywhere in the world with an \r\nLMS for the m" +
    "odern workforce.\r\n";
            this.sloganLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sloganLabel2
            // 
            this.sloganLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sloganLabel2.AutoSize = true;
            this.sloganLabel2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sloganLabel2.ForeColor = System.Drawing.Color.Coral;
            this.sloganLabel2.Location = new System.Drawing.Point(244, 48);
            this.sloganLabel2.Name = "sloganLabel2";
            this.sloganLabel2.Size = new System.Drawing.Size(382, 35);
            this.sloganLabel2.TabIndex = 2;
            this.sloganLabel2.Text = "Easily Train Your Remote Team\r\n";
            // 
            // goback_btn1
            // 
            this.goback_btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goback_btn1.BackColor = System.Drawing.Color.Transparent;
            this.goback_btn1.BorderColor = System.Drawing.Color.Transparent;
            this.goback_btn1.ButtonColor = System.Drawing.Color.YellowGreen;
            this.goback_btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.goback_btn1.FlatAppearance.BorderSize = 0;
            this.goback_btn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.goback_btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.goback_btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.goback_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback_btn1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goback_btn1.ForeColor = System.Drawing.Color.Transparent;
            this.goback_btn1.Location = new System.Drawing.Point(74, 198);
            this.goback_btn1.Margin = new System.Windows.Forms.Padding(2);
            this.goback_btn1.Name = "goback_btn1";
            this.goback_btn1.OnHoverBorderColor = System.Drawing.Color.DarkGreen;
            this.goback_btn1.OnHoverButtonColor = System.Drawing.Color.DarkGreen;
            this.goback_btn1.OnHoverTextColor = System.Drawing.Color.Black;
            this.goback_btn1.Size = new System.Drawing.Size(113, 40);
            this.goback_btn1.TabIndex = 18;
            this.goback_btn1.Text = "Continue";
            this.goback_btn1.TextColor = System.Drawing.Color.Black;
            this.goback_btn1.UseVisualStyleBackColor = false;
            this.goback_btn1.Click += new System.EventHandler(this.goback_btn1_Click);
            // 
            // SplashPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 238);
            this.Controls.Add(this.goback_btn1);
            this.Controls.Add(this.sloganLabel2);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private ePOSOne.btnProduct.Button_WOC goback_btn1;
    }
}

