/**
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

        // Used to deside if the user is trying to close the program
        // we assume if the program is being closed, the user wants to exit
        // unless the submit button gets hit, then the user doesn't want
        // to exit the whole program.
        bool closeProgram = true;

        /**
         * Constructor
         */
        public LoginPage(DataBaseManager dbManager)
        {
            InitializeComponent();
            this.dbManager = dbManager;
        }

        /**
         * Called when the user clicks the submit button
         */
        private void submitButton_Click(object sender, EventArgs e)
        {
            closeProgram = false;
            //  Check if the user properly logged in
            if (checkLogin()){

                // Close this form
                this.Close();

                // Open the choose trainer form
                ChooseTrainerPage tp = new ChooseTrainerPage();
                tp.Show();
            }
            else{
                statusStrip.Text = "Wrong Username/Password!";
                //statusStrip1.Refresh();
            }
            
        }

        /**
         * Checks the users referenced login information against the DB
         * to see if they are allowed to login. Returns true if they are
         * allowed, and returns false if they are not.
         */
        private bool checkLogin(){
            // Setup our return data
            bool returnVal = false;

            // Get our info from the form.
            string userName = tb_userName.Text;
            string password = tb_password.Text;

            // Set up a structure to save our response
            List<NameValueCollection> queryResult;

            // Execute the Query, checking for username and password.
            queryResult = dbManager.query("SELECT * FROM user WHERE userName = '"+userName+"' AND password = '"+password+"'");
            if(queryResult.Count >= 1)
            {
                returnVal = true;
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
        private void closeForm(Object sender, FormClosingEventArgs e){

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
    }
}
