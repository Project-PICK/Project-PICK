/**
 * RegisterPage.cs
 * Project-PICK
 * 10/15/2020
 * Authors: Isaac Travers, Candace Moore, Phillip Toulinov, Kyle Smith
 * 
 * Manages registering new users
 */

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICKTrainingInc
{

    public partial class RegisterPage : Form
    {
        /* Field Variables */
        DataBaseManager dbManager;
        StateManager stateManager;

        /*Used to deside if the user is trying to close the program
        // we assume if the program is being closed, the user wants to exit
        // unless the submit button gets hit, then the user doesn't want
        // to exit the whole program. */
        bool closeProgram = true;

        /**
         * Constructor
         */
        public RegisterPage(DataBaseManager dbManager, StateManager stateManager)
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(closeForm);

            this.dbManager = dbManager;
            this.stateManager = stateManager;
        }


    


        /**
         * Called When the user tries to close the form
         */
        private void closeForm(Object sender, FormClosingEventArgs e)
        {

            // Only prompt the user if we are pressing the close button.
            if (closeProgram)
            {
                // Issue the cancel command. We don't ever want to close the program from the register page
                e.Cancel = true;

                // Instead we will open back up the login page
                LoginPage lp = new LoginPage(dbManager, stateManager);

                // Close the register page.
                this.Hide();

                // Show the login Page
                lp.Show();

                

                closeProgram = false;

                
            }

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Enter(object sender, EventArgs e)
        {

        }

        /**
         * Called when the user clicks the submit button. 
         */
        private void submitButton_Click_1(object sender, EventArgs e)
        {
            // We want the gui to know we aren't clicking the exit button.
            closeProgram = false;

            string userName = tb_userName.Text;
            string password = tb_password.Text;

            //TODO: Sanitize this sql input.

            // Create our insert Query
            string query = "INSERT INTO user (userName, password) VALUES('" + userName + "', '" + password + "');";

            // Attempt the insert
            if (dbManager.insert(query))
            {
                // Set our username in the state Machine.
                stateManager.setUserName(userName);

                // Close this form
                this.Close();

                // Open the choose trainer form
                ChooseTrainerPage tp = new ChooseTrainerPage(dbManager, stateManager);
                tp.Show();
            }
            else
            {

                // Show error to user
                statusBar.Text = "Error, could not register user: " + userName;

                // Hey maybe we will click the exit button next time.
                closeProgram = true;
            }

        }
    }
}
