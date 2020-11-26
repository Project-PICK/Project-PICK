namespace PICKTrainingInc
{
    partial class MainTrainingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTrainingPage));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbl_answers = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_stats = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.currentUser = new System.Windows.Forms.Label();
            this.allUsers = new System.Windows.Forms.Label();
            this.totalAnswered = new System.Windows.Forms.Label();
            this.totalCorrect = new System.Windows.Forms.Label();
            this.totalWrong = new System.Windows.Forms.Label();
            this.currentUserCorrect = new System.Windows.Forms.Label();
            this.currentUserWrong = new System.Windows.Forms.Label();
            this.currentUserTotal = new System.Windows.Forms.Label();
            this.allUserCorrect = new System.Windows.Forms.Label();
            this.allUserWrong = new System.Windows.Forms.Label();
            this.allUserTotal = new System.Windows.Forms.Label();
          //  this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
           // this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pb_question = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goback = new ePOSOne.btnProduct.Button_WOC();
            this.menuOptions = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbl_answers.SuspendLayout();
            this.gb_stats.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
          //  ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_question)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Logo.InitialImage")));
            this.Logo.Location = new System.Drawing.Point(18, 61);
            this.Logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(140, 131);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.tbl_answers);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(784, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(484, 629);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Your Answer";
            // 
            // tbl_answers
            // 
            this.tbl_answers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_answers.ColumnCount = 3;
            this.tbl_answers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_answers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_answers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_answers.Controls.Add(this.button1, 0, 0);
            this.tbl_answers.Location = new System.Drawing.Point(27, 38);
            this.tbl_answers.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbl_answers.Name = "tbl_answers";
            this.tbl_answers.RowCount = 5;
            this.tbl_answers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_answers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_answers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_answers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_answers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl_answers.Size = new System.Drawing.Size(435, 568);
            this.tbl_answers.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(5, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Andy Warhol";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // gb_stats
            // 
            this.gb_stats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_stats.Controls.Add(this.tableLayoutPanel2);
            this.gb_stats.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_stats.Location = new System.Drawing.Point(165, 77);
            this.gb_stats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_stats.Name = "gb_stats";
            this.gb_stats.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_stats.Size = new System.Drawing.Size(594, 115);
            this.gb_stats.TabIndex = 5;
            this.gb_stats.TabStop = false;
            this.gb_stats.Text = "Question Statistics";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel2.Controls.Add(this.currentUser, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.allUsers, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.totalAnswered, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.totalCorrect, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.totalWrong, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.currentUserCorrect, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.currentUserWrong, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.currentUserTotal, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.allUserCorrect, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.allUserWrong, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.allUserTotal, 2, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(561, 80);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // currentUser
            // 
            this.currentUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentUser.AutoSize = true;
            this.currentUser.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUser.Location = new System.Drawing.Point(233, 0);
            this.currentUser.Name = "currentUser";
            this.currentUser.Size = new System.Drawing.Size(110, 19);
            this.currentUser.TabIndex = 3;
            this.currentUser.Text = "Current User";
            // 
            // allUsers
            // 
            this.allUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allUsers.AutoSize = true;
            this.allUsers.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUsers.Location = new System.Drawing.Point(433, 0);
            this.allUsers.Name = "allUsers";
            this.allUsers.Size = new System.Drawing.Size(79, 19);
            this.allUsers.TabIndex = 2;
            this.allUsers.Text = "All Users";
            // 
            // totalAnswered
            // 
            this.totalAnswered.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalAnswered.AutoSize = true;
            this.totalAnswered.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAnswered.Location = new System.Drawing.Point(66, 60);
            this.totalAnswered.Name = "totalAnswered";
            this.totalAnswered.Size = new System.Drawing.Size(123, 19);
            this.totalAnswered.TabIndex = 1;
            this.totalAnswered.Text = "Total Answered";
            // 
            // totalCorrect
            // 
            this.totalCorrect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalCorrect.AutoSize = true;
            this.totalCorrect.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCorrect.Location = new System.Drawing.Point(83, 20);
            this.totalCorrect.Name = "totalCorrect";
            this.totalCorrect.Size = new System.Drawing.Size(106, 19);
            this.totalCorrect.TabIndex = 5;
            this.totalCorrect.Text = "Total Correct";
            // 
            // totalWrong
            // 
            this.totalWrong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalWrong.AutoSize = true;
            this.totalWrong.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalWrong.Location = new System.Drawing.Point(89, 40);
            this.totalWrong.Name = "totalWrong";
            this.totalWrong.Size = new System.Drawing.Size(100, 19);
            this.totalWrong.TabIndex = 4;
            this.totalWrong.Text = "Total Wrong";
            // 
            // currentUserCorrect
            // 
            this.currentUserCorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentUserCorrect.AutoSize = true;
            this.currentUserCorrect.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserCorrect.Location = new System.Drawing.Point(274, 20);
            this.currentUserCorrect.Name = "currentUserCorrect";
            this.currentUserCorrect.Size = new System.Drawing.Size(27, 19);
            this.currentUserCorrect.TabIndex = 6;
            this.currentUserCorrect.Text = "50";
            // 
            // currentUserWrong
            // 
            this.currentUserWrong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentUserWrong.AutoSize = true;
            this.currentUserWrong.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserWrong.Location = new System.Drawing.Point(274, 40);
            this.currentUserWrong.Name = "currentUserWrong";
            this.currentUserWrong.Size = new System.Drawing.Size(27, 19);
            this.currentUserWrong.TabIndex = 7;
            this.currentUserWrong.Text = "10";
            // 
            // currentUserTotal
            // 
            this.currentUserTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentUserTotal.AutoSize = true;
            this.currentUserTotal.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserTotal.Location = new System.Drawing.Point(274, 60);
            this.currentUserTotal.Name = "currentUserTotal";
            this.currentUserTotal.Size = new System.Drawing.Size(27, 19);
            this.currentUserTotal.TabIndex = 8;
            this.currentUserTotal.Text = "60";
            // 
            // allUserCorrect
            // 
            this.allUserCorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allUserCorrect.AutoSize = true;
            this.allUserCorrect.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUserCorrect.Location = new System.Drawing.Point(454, 20);
            this.allUserCorrect.Name = "allUserCorrect";
            this.allUserCorrect.Size = new System.Drawing.Size(36, 19);
            this.allUserCorrect.TabIndex = 9;
            this.allUserCorrect.Text = "100";
            // 
            // allUserWrong
            // 
            this.allUserWrong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allUserWrong.AutoSize = true;
            this.allUserWrong.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUserWrong.Location = new System.Drawing.Point(459, 40);
            this.allUserWrong.Name = "allUserWrong";
            this.allUserWrong.Size = new System.Drawing.Size(27, 19);
            this.allUserWrong.TabIndex = 10;
            this.allUserWrong.Text = "45";
            // 
            // allUserTotal
            // 
            this.allUserTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allUserTotal.AutoSize = true;
            this.allUserTotal.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUserTotal.Location = new System.Drawing.Point(454, 60);
            this.allUserTotal.Name = "allUserTotal";
            this.allUserTotal.Size = new System.Drawing.Size(36, 19);
            this.allUserTotal.TabIndex = 11;
            this.allUserTotal.Text = "145";
            // 
            // userBindingSource
            // 
           // this.userBindingSource.DataMember = "User";
           // this.userBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.pb_question);
            this.groupBox3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 202);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(741, 505);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Question";
            // 
            // pb_question
            // 
            this.pb_question.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_question.Image = ((System.Drawing.Image)(resources.GetObject("pb_question.Image")));
            this.pb_question.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_question.InitialImage")));
            this.pb_question.Location = new System.Drawing.Point(22, 38);
            this.pb_question.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_question.Name = "pb_question";
            this.pb_question.Size = new System.Drawing.Size(711, 457);
            this.pb_question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_question.TabIndex = 4;
            this.pb_question.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(238, 32);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(213, 25);
            this.toolStripStatusLabel1.Text = "Welcome to Your Training";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_welcome.Location = new System.Drawing.Point(225, 39);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(475, 33);
            this.lbl_welcome.TabIndex = 8;
            this.lbl_welcome.Text = "Test Class Training For Test User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1394, 742);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Project PICK";
            // 
            // goback
            // 
            this.goback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goback.BackColor = System.Drawing.Color.Transparent;
            this.goback.BorderColor = System.Drawing.Color.Transparent;
            this.goback.ButtonColor = System.Drawing.Color.YellowGreen;
            this.goback.FlatAppearance.BorderSize = 0;
            this.goback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback.ForeColor = System.Drawing.Color.Transparent;
            this.goback.Location = new System.Drawing.Point(1101, 39);
            this.goback.Name = "goback";
            this.goback.OnHoverBorderColor = System.Drawing.Color.DarkGreen;
            this.goback.OnHoverButtonColor = System.Drawing.Color.DarkGreen;
            this.goback.OnHoverTextColor = System.Drawing.Color.Black;
            this.goback.Size = new System.Drawing.Size(145, 54);
            this.goback.TabIndex = 17;
            this.goback.Text = "Go Back";
            this.goback.TextColor = System.Drawing.Color.Black;
            this.goback.UseVisualStyleBackColor = false;
            this.goback.Click += new System.EventHandler(this.goback_Click);
            // 
            // menuOptions
            // 
            this.menuOptions.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuOptions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.navigationToolStripMenuItem});
            this.menuOptions.Location = new System.Drawing.Point(0, 0);
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(1284, 33);
            this.menuOptions.TabIndex = 18;
            this.menuOptions.Text = "menuStrip2";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.chooseTrainingToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(114, 29);
            this.navigationToolStripMenuItem.Text = "Navigation";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // chooseTrainingToolStripMenuItem
            // 
            this.chooseTrainingToolStripMenuItem.Name = "chooseTrainingToolStripMenuItem";
            this.chooseTrainingToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.chooseTrainingToolStripMenuItem.Text = "Choose Training";
            this.chooseTrainingToolStripMenuItem.Click += new System.EventHandler(this.chooseTrainingToolStripMenuItem_Click);
            // 
            // MainTrainingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 741);
            this.Controls.Add(this.menuOptions);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_stats);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainTrainingPage";
            this.Text = "MainTrainingPage";
            this.Load += new System.EventHandler(this.MainTrainingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tbl_answers.ResumeLayout(false);
            this.gb_stats.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
          //  ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_question)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuOptions.ResumeLayout(false);
            this.menuOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_stats;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TableLayoutPanel tbl_answers;
        private System.Windows.Forms.PictureBox pb_question;
        //private System.Windows.Forms.BindingSource userBindingSource;
        //private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label totalWrong;
        private System.Windows.Forms.Label totalAnswered;
        private System.Windows.Forms.Label currentUser;
        private System.Windows.Forms.Label allUsers;
        private System.Windows.Forms.Label totalCorrect;
        private System.Windows.Forms.Label currentUserCorrect;
        private System.Windows.Forms.Label currentUserWrong;
        private System.Windows.Forms.Label currentUserTotal;
        private System.Windows.Forms.Label allUserCorrect;
        private System.Windows.Forms.Label allUserWrong;
        private System.Windows.Forms.Label allUserTotal;
        private System.Windows.Forms.Button button1;
        private ePOSOne.btnProduct.Button_WOC goback;
        private System.Windows.Forms.MenuStrip menuOptions;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseTrainingToolStripMenuItem;
    }
}
