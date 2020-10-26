namespace PICKTrainingInc
{
    partial class ChooseTrainerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseTrainerPage));
            this.menuOptions = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.chooseTrainingLabel = new System.Windows.Forms.Label();
            this.fillPanel = new System.Windows.Forms.Panel();
            this.tp_training = new System.Windows.Forms.TableLayoutPanel();
            this.gb_training1 = new System.Windows.Forms.GroupBox();
            this.pb_training1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.gb_training = new System.Windows.Forms.GroupBox();
            this.menuOptions.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.fillPanel.SuspendLayout();
            this.tp_training.SuspendLayout();
            this.gb_training1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_training1)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.gb_training.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuOptions
            // 
            this.menuOptions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.userOptionsToolStripMenuItem});
            this.menuOptions.Location = new System.Drawing.Point(0, 0);
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuOptions.Size = new System.Drawing.Size(857, 24);
            this.menuOptions.TabIndex = 8;
            this.menuOptions.Text = "menuStrip2";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.exitToolStripMenuItem.Text = "Exit ";
            // 
            // userOptionsToolStripMenuItem
            // 
            this.userOptionsToolStripMenuItem.Name = "userOptionsToolStripMenuItem";
            this.userOptionsToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.userOptionsToolStripMenuItem.Text = "User Options";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 515);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(857, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(119, 17);
            this.statusBar.Text = "Choose Your Training";
            // 
            // Logo
            // 
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(12, 27);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(136, 101);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 5;
            this.Logo.TabStop = false;
            // 
            // chooseTrainingLabel
            // 
            this.chooseTrainingLabel.AutoSize = true;
            this.chooseTrainingLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseTrainingLabel.Location = new System.Drawing.Point(281, 41);
            this.chooseTrainingLabel.Name = "chooseTrainingLabel";
            this.chooseTrainingLabel.Size = new System.Drawing.Size(178, 23);
            this.chooseTrainingLabel.TabIndex = 10;
            this.chooseTrainingLabel.Text = "Default Text Here";
            // 
            // fillPanel
            // 
            this.fillPanel.AutoScroll = true;
            this.fillPanel.Controls.Add(this.tp_training);
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(2, 17);
            this.fillPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(828, 353);
            this.fillPanel.TabIndex = 11;
            // 
            // tp_training
            // 
            this.tp_training.ColumnCount = 3;
            this.tp_training.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tp_training.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tp_training.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tp_training.Controls.Add(this.gb_training1, 0, 0);
            this.tp_training.Dock = System.Windows.Forms.DockStyle.Top;
            this.tp_training.Location = new System.Drawing.Point(0, 0);
            this.tp_training.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tp_training.Name = "tp_training";
            this.tp_training.RowCount = 4;
            this.tp_training.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.3369F));
            this.tp_training.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.6631F));
            this.tp_training.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tp_training.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tp_training.Size = new System.Drawing.Size(811, 665);
            this.tp_training.TabIndex = 0;
            // 
            // gb_training1
            // 
            this.gb_training1.Controls.Add(this.pb_training1);
            this.gb_training1.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_training1.Location = new System.Drawing.Point(2, 2);
            this.gb_training1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_training1.Name = "gb_training1";
            this.gb_training1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_training1.Size = new System.Drawing.Size(264, 153);
            this.gb_training1.TabIndex = 1;
            this.gb_training1.TabStop = false;
            this.gb_training1.Text = "Marine Life";
            // 
            // pb_training1
            // 
            this.pb_training1.Image = ((System.Drawing.Image)(resources.GetObject("pb_training1.Image")));
            this.pb_training1.Location = new System.Drawing.Point(5, 23);
            this.pb_training1.Name = "pb_training1";
            this.pb_training1.Size = new System.Drawing.Size(259, 125);
            this.pb_training1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_training1.TabIndex = 0;
            this.pb_training1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.gb_training);
            this.mainPanel.Location = new System.Drawing.Point(0, 133);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(837, 376);
            this.mainPanel.TabIndex = 12;
            // 
            // gb_training
            // 
            this.gb_training.Controls.Add(this.fillPanel);
            this.gb_training.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_training.Location = new System.Drawing.Point(3, 2);
            this.gb_training.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_training.Name = "gb_training";
            this.gb_training.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_training.Size = new System.Drawing.Size(832, 372);
            this.gb_training.TabIndex = 12;
            this.gb_training.TabStop = false;
            this.gb_training.Text = "Choose Your Training Course";
            // 
            // ChooseTrainerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 537);
            this.Controls.Add(this.chooseTrainingLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.menuOptions);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseTrainerPage";
            this.Text = "Choose Trainer";
            this.Load += new System.EventHandler(this.ChooseTrainerPage_Load);
            this.menuOptions.ResumeLayout(false);
            this.menuOptions.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.fillPanel.ResumeLayout(false);
            this.tp_training.ResumeLayout(false);
            this.gb_training1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_training1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.gb_training.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.MenuStrip menuOptions;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userOptionsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.Label chooseTrainingLabel;
        private System.Windows.Forms.Panel fillPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox gb_training;
        private System.Windows.Forms.TableLayoutPanel tp_training;
        private System.Windows.Forms.GroupBox gb_training1;
        private System.Windows.Forms.PictureBox pb_training1;
    }
}