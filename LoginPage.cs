﻿/**
 * LoginPage.cs
 * Project-PICK
 * 10/10/2020
 * Authors: Isaac Travers, Candace Moore, Phillip Toulinov, Kyle Smith
 */

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICKTrainingInc
{
    public partial class LoginPage : Form
    {

        //Used to manage the db connection
        DataBaseManager dbManager;
        StateManager stateManager;

        // Used to deside if the user is trying to close the program
        // we assume if the program is being closed, the user wants to exit
        // unless the submit button gets hit, then the user doesn't want
        // to exit the whole program.
        bool closeProgram = true;

        /**
         * Constructor
         */
        public LoginPage(DataBaseManager dbManager, StateManager stateManager)
        {
            InitializeComponent();
            this.dbManager = dbManager;
            this.stateManager = stateManager;
        }

        /**
         * Called when the user clicks the submit button
         */
        private void submitButton_Click(object sender, EventArgs e)
        {
            closeProgram = false;
            //  Check if the user properly logged in
            if (checkLogin()) {

                // Close this form
                this.Close();

                // Open the choose trainer form
                ChooseTrainerPage tp = new ChooseTrainerPage(dbManager, stateManager);
                tp.Show();
            }
            else {
                statusStrip.Text = "Wrong Username/Password!";
                //statusStrip1.Refresh();
            }

        }


        /**
         * Checks the users referenced login information against the DB
         * to see if they are allowed to login. Returns true if they are
         * allowed, and returns false if they are not.
         */
        private bool checkLogin() {
            // Setup our return data
            bool returnVal = false;

            // Get our info from the form.
            string userName = tb_userName.Text;
            string password = tb_password.Text;

            // Set up a structure to save our response
            List<NameValueCollection> queryResult;

            // Execute the Query, checking for username and password.
            queryResult = dbManager.query("SELECT * FROM user WHERE userName = '" + userName + "' AND password = '" + password + "'");

            //queryResult = dbManager.query("SELECT * FROM user WHERE userName = @user_name AND password = @pass_word");

            if (queryResult.Count >= 1)
            {
                returnVal = true;
                stateManager.setUserName(userName, password);
                stateManager.setFirstName(queryResult[0]["firstName"]);
                stateManager.setLastName(queryResult[0]["lastName"]);
                stateManager.setPassword(password);
                string str_isAdmin = queryResult[0]["isAdmin"];

                bool isAdmin;

                if (str_isAdmin == "") {
                    isAdmin = false;
                }
                else
                {
                  isAdmin  = bool.Parse(queryResult[0]["isAdmin"]);
                }
                
                
                stateManager.setIsAdmin(isAdmin);
            }
            else
            {
                returnVal = false;
            }

            return returnVal;
        }

        /**
         * Called When the user tries to close the form
         */
        private void closeForm(Object sender, FormClosingEventArgs e) {

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

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            closeProgram = false;

            RegisterPage rp = new RegisterPage(dbManager, stateManager);
            this.Close();

            rp.Show();
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {


        }

        private void tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                submit_button.PerformClick();
            }
        }

        /**
          * Called When the user selects to view their password in plain text
         */
        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                tb_password.UseSystemPasswordChar = false;
            }
            else
            {
                tb_password.UseSystemPasswordChar = true;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void goback_btn_Click(object sender, EventArgs e)
        {
           closeProgram = false;

            this.Close();
            SplashPage sp = new SplashPage(dbManager, stateManager);
            sp.Show(); 
        }

        private void goback_btn1_Click(object sender, EventArgs e)
        {
            closeProgram = false;

            this.Close();
            SplashPage sp = new SplashPage(dbManager, stateManager);
            sp.Show();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            closeProgram = false;

            RegisterPage rp = new RegisterPage(dbManager, stateManager);
            this.Close();

            rp.Show();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            closeProgram = false;
            //  Check if the user properly logged in
            if (checkLogin())
            {

                // Close this form
                this.Close();

                // Open the choose trainer form
                ChooseTrainerPage tp = new ChooseTrainerPage(dbManager, stateManager);
                tp.Show();
            }
            else
            {
                statusStrip.Text = "Wrong Username/Password!";
                //statusStrip1.Refresh();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
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
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            {
                // Show a dialog box.
                DialogResult d = MessageBox.Show("Are You Sure You Want To Change Your Password?", "Project PICK", MessageBoxButtons.YesNo);
                if (d == DialogResult.No)
                {
                    DialogResult a = MessageBox.Show("You will now be redirected to the Login Screen");
                    // don't do anything
                }
                else
                {
                    DialogResult a = MessageBox.Show("The Administrator has been contacted, please wait for an email.");
                    closeProgram = true;
                    System.Environment.Exit(1);
                }
            }
        }

    }
}