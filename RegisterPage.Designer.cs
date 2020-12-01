﻿namespace PICKTrainingInc
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.Register = new System.Windows.Forms.GroupBox();
            this.exitButton = new ePOSOne.btnProduct.Button_WOC();
            this.goback_btn1 = new ePOSOne.btnProduct.Button_WOC();
            this.submit_button2 = new ePOSOne.btnProduct.Button_WOC();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.Register.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(327, 284);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(825, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "Please Register to Continue with Project PICK Training";
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.White;
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(85, 17);
            this.statusBar.Text = "Register Please";
            this.statusBar.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Register
            // 
            this.Register.Controls.Add(this.exitButton);
            this.Register.Controls.Add(this.goback_btn1);
            this.Register.Controls.Add(this.submit_button2);
            this.Register.Controls.Add(this.tableLayoutPanel1);
            this.Register.Dock = System.Windows.Forms.DockStyle.Right;
            this.Register.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.Color.Coral;
            this.Register.Location = new System.Drawing.Point(345, 0);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(480, 339);
            this.Register.TabIndex = 9;
            this.Register.TabStop = false;
            this.Register.Text = "Register Here";
            this.Register.Enter += new System.EventHandler(this.SignIn_Enter);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BorderColor = System.Drawing.Color.Transparent;
            this.exitButton.ButtonColor = System.Drawing.Color.Coral;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Transparent;
            this.exitButton.Location = new System.Drawing.Point(184, 258);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.OnHoverBorderColor = System.Drawing.Color.DarkGreen;
            this.exitButton.OnHoverButtonColor = System.Drawing.Color.DarkGreen;
            this.exitButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.exitButton.Size = new System.Drawing.Size(113, 40);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit";
            this.exitButton.TextColor = System.Drawing.Color.Black;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // goback_btn1
            // 
            this.goback_btn1.BackColor = System.Drawing.Color.Transparent;
            this.goback_btn1.BorderColor = System.Drawing.Color.Transparent;
            this.goback_btn1.ButtonColor = System.Drawing.Color.Coral;
            this.goback_btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.goback_btn1.FlatAppearance.BorderSize = 0;
            this.goback_btn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.goback_btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.goback_btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.goback_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback_btn1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goback_btn1.ForeColor = System.Drawing.Color.Transparent;
            this.goback_btn1.Location = new System.Drawing.Point(6, 257);
            this.goback_btn1.Margin = new System.Windows.Forms.Padding(2);
            this.goback_btn1.Name = "goback_btn1";
            this.goback_btn1.OnHoverBorderColor = System.Drawing.Color.DarkGreen;
            this.goback_btn1.OnHoverButtonColor = System.Drawing.Color.DarkGreen;
            this.goback_btn1.OnHoverTextColor = System.Drawing.Color.Black;
            this.goback_btn1.Size = new System.Drawing.Size(113, 40);
            this.goback_btn1.TabIndex = 17;
            this.goback_btn1.Text = "Go Back";
            this.goback_btn1.TextColor = System.Drawing.Color.Black;
            this.goback_btn1.UseVisualStyleBackColor = false;
            this.goback_btn1.Click += new System.EventHandler(this.goback_btn1_Click);
            // 
            // submit_button2
            // 
            this.submit_button2.BackColor = System.Drawing.Color.Transparent;
            this.submit_button2.BorderColor = System.Drawing.Color.Transparent;
            this.submit_button2.ButtonColor = System.Drawing.Color.Coral;
            this.submit_button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.submit_button2.FlatAppearance.BorderSize = 0;
            this.submit_button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.submit_button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.submit_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button2.ForeColor = System.Drawing.Color.Transparent;
            this.submit_button2.Location = new System.Drawing.Point(362, 258);
            this.submit_button2.Margin = new System.Windows.Forms.Padding(2);
            this.submit_button2.Name = "submit_button2";
            this.submit_button2.OnHoverBorderColor = System.Drawing.Color.DarkGreen;
            this.submit_button2.OnHoverButtonColor = System.Drawing.Color.DarkGreen;
            this.submit_button2.OnHoverTextColor = System.Drawing.Color.Black;
            this.submit_button2.Size = new System.Drawing.Size(113, 40);
            this.submit_button2.TabIndex = 16;
            this.submit_button2.Text = "Submit";
            this.submit_button2.TextColor = System.Drawing.Color.Black;
            this.submit_button2.UseVisualStyleBackColor = false;
            this.submit_button2.Click += new System.EventHandler(this.submit_button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UsernameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_userName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 198);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(3, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(230, 56);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(222, 30);
            this.tb_password.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Coral;
            this.UsernameLabel.Location = new System.Drawing.Point(3, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(108, 29);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username";
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(230, 3);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(222, 30);
            this.tb_userName.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 30);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(230, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 30);
            this.textBox2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(3, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name";
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(825, 361);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterPage";
            this.Text = "Register New User";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Register.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.GroupBox Register;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox tb_userName;
        private ePOSOne.btnProduct.Button_WOC submit_button2;
        private ePOSOne.btnProduct.Button_WOC goback_btn1;
        private ePOSOne.btnProduct.Button_WOC exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}