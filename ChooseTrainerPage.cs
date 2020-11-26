/**
 * ChooseTrainerPage.cs
 * Project-PICK
 * 10/10/2020
 * Authors: Isaac Travers, Candace Moore, Phillip Toulinov, Kyle Smith
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICKTrainingInc
{
    public partial class ChooseTrainerPage : Form
    {

        /* Field Variables */
        DataBaseManager dbManager;
        StateManager stateManager;
        bool closeProgram = true;

        string user;                        /* Keeps track of our current user's name */
        ArrayList trainingNames;             /* Keeps track of the names of our possible trainings. */
        ArrayList trainingDirectories;      /* Keeps track of all the directory names of training. */
        ArrayList coverImageLocations;      /* List the location of all cover images. */

        /*
         * Constructor
         */
        public ChooseTrainerPage(DataBaseManager dbManager, StateManager stateManager)
        {
            InitializeComponent();
            this.dbManager = dbManager;
            this.stateManager = stateManager;
            this.FormClosing += new FormClosingEventHandler(closeForm);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        /**
         * Called when the form loads.
         */
        private void ChooseTrainerPage_Load(object sender, EventArgs e)
        {
            // Get and assign the user.
            user = getUser();
            setName(user);
            setStatusBar(user);

            //set our demo training to invisible
            gb_training1.Visible = false;

            trainingDirectories = getTrainingDirectories();

            // Read a list of training names from file system.
            trainingNames = getTrainingNames();

            // Get Cover image location
            coverImageLocations = getCoverImageLocations(trainingDirectories);

            // Add the training Boxes.
            addTrainingBoxes(trainingDirectories, trainingNames, coverImageLocations);
        }

        /**
         * Adds the needed training boxes based on the file system datasets that are setup.
         * */
        private void addTrainingBoxes(ArrayList trainingDirectories, ArrayList trainingNames, ArrayList coverImageLocations){
            for(int i = 0; i < trainingDirectories.Count; i++) {
                string imageLoc = (string)coverImageLocations[i];
                string trainingName = (string)trainingNames[i];

                //create the picturebox
                PictureBox picBox = new PictureBox();
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.Image = Image.FromFile(imageLoc);
                picBox.Location = new System.Drawing.Point(10, 20);
                picBox.MinimumSize = new System.Drawing.Size(240, 130);
                picBox.Name = trainingName;
                picBox.Visible = true;
                picBox.Click += new System.EventHandler(this.training_CLICK);

                GroupBox groupBox = new GroupBox();
                groupBox.Text = trainingName;
                groupBox.Size = new System.Drawing.Size(260, 160);
                groupBox.MinimumSize = new System.Drawing.Size(260, 160);
                groupBox.Font = gb_training1.Font;
                groupBox.Visible = true;

                groupBox.Controls.Add(picBox);
                tp_training.Controls.Add(groupBox);

            }
        }

        private ArrayList getCoverImageLocations(ArrayList trainingDirectories)
        {
            ArrayList coverImageLocations = new ArrayList();
            foreach(string dir in trainingDirectories)
            {
                coverImageLocations.Add(dir + "/cover.jpg");
            }

            return coverImageLocations;
        }

        /*
         * Reads the Name of Every Training Data folder.
         * Saves into field array.
         */
        private ArrayList getTrainingNames(){
            string[] dirs = Directory.GetDirectories(@"..\..\TrainingData\", "*", SearchOption.TopDirectoryOnly);
            ArrayList cleanDirs = cleanDirectories(dirs);
            return cleanDirs;
        }

        /*
        * Returns the directory of all training data
        */
        private ArrayList getTrainingDirectories()
        {
            ArrayList directories = new ArrayList();
            string[] dirs = Directory.GetDirectories("../../TrainingData/", "*", SearchOption.TopDirectoryOnly);
            foreach (string dir in dirs){
                directories.Add(dir);
            }
                return directories;
        }

        /**
         * Cleans the path out of a list of string directories
         * */
        private ArrayList cleanDirectories(string[] unclean){
            ArrayList clean = new ArrayList();

            foreach(string item in unclean){
                int start = item.LastIndexOf(@"\")+1;
                int end = item.Length-1;
                clean.Add(item.Substring(start));
            }

            return clean;
        }

        /* Returns the name of the currently logged in user */
        private string getUser(){
            //TODO: Implement actual getUser
            return stateManager.getUserName();
        }

        /* Sets the username for the current form */
        private void setName(string name)
        {
            chooseTrainingLabel.Text = "Hello " + name + ", \nPlease Choose Your Training Course!";

        }

        /**
         * We're trying to close this form, and the program
         * */
        private void closeForm(Object sender, FormClosingEventArgs e)
        {
            // Only prompt the user if we are pressing the close button.
            if (closeProgram)
            {
                // Show a dialog box.
                DialogResult d = MessageBox.Show("Are You Sure You Want To Exit?", "Project PICK", MessageBoxButtons.YesNo);
                if (d == DialogResult.No)
                {

                    // Issue the cancel command.
                    e.Cancel = true;
                }
                else
                {
                    closeProgram = true;
                    System.Environment.Exit(1);
                }
            }
        }

        /**
         * User clicked a specific training class
         * */
        private void training_CLICK(object sender, EventArgs e)
        {
            // Keeps the, are you sure you want to close popup from happening.
            closeProgram = false;

            string trainingName = ((PictureBox)sender).Name;
            statusBar.Text = trainingName;

            stateManager.setTrainingName(trainingName);

            MainTrainingPage mtp = new MainTrainingPage(dbManager, stateManager);
            mtp.Show();
            this.Hide();
        }

        /**
         * User clicked the original goback button, kept for backwards capatibility
         * */
        private void goback_btn_Click(object sender, EventArgs e)
        {
            closeProgram = false;

            this.Close();
            LoginPage lp = new LoginPage(dbManager, stateManager);
            lp.Show();
        }

        /**
         * Test Functionm
         * */
        private void statusBar_Click(object sender, EventArgs e)
        {

        }

        /**
         * Just a test function
         */
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello");
            statusBar.Text = "Hello";
        }

        /**
         * Sets the status bar to welcome back the user
         */
        private void setStatusBar(string name)
        {
            statusBar.Text = "Welcome back, " + name + "!";
        }

        /**
         * User clicked the goback button
         */
        private void goback_btn2_Click(object sender, EventArgs e)
        {
            closeProgram = false;

            this.Close();
            LoginPage lp = new LoginPage(dbManager, stateManager);
            lp.Show();
        }

        /**
         * User Clicked the "Exit" Button on the menu"
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show a dialog box.
            DialogResult d = MessageBox.Show("Are You Sure You Want To Exit?", "Project PICK", MessageBoxButtons.YesNo);
            if (d == DialogResult.No)
            {

                // don't do anything
            }
            else
            {
                closeProgram = true;
                System.Environment.Exit(1);
            }
        }

        /**
         * User clicked the dashboard button on the menu
         * */
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeProgram = false;

            this.Close();
            Dashboard dashboard = new Dashboard(dbManager, stateManager);
            dashboard.Show();
        }

        /**
         * User Clicked the logout button on the menuj
         * */
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeProgram = false; 

            this.Close();
            LoginPage lp = new LoginPage(dbManager, stateManager);
            lp.Show();
        }
    }
}
