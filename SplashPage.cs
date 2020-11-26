/**
 * SplashPage.cs
 * Project-PICK
 * 10/10/2020
 * Authors: Isaac Travers, Candace Moore, Phillip Toulinov, Kyle Smith
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Timers;
using System.Runtime.CompilerServices;
using System.Data.Entity.Core.Objects;

namespace PICKTrainingInc
{
    public partial class SplashPage : Form
    {
        /* Field Variables Here */
        DataBaseManager dbManager;
        StateManager stateManager;

        // Used to time when the spash screen should be closed. 
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        /**
         * Constructor, Called when the page is created.
         */
        public SplashPage(DataBaseManager dbManager, StateManager stateManager)
        {
            InitializeComponent();
            this.dbManager = dbManager;
            this.stateManager = stateManager;
            this.FormClosing += new FormClosingEventHandler(closeForm);
        }

        /**
         * To be called when the user tries to close the form.
         */
        private void closeForm(Object sender, FormClosingEventArgs e)
        {
            // We don't want the timer to run while our dialog box is showing.
            timer.Stop();

            // Show a dialog box.
            DialogResult d = MessageBox.Show("Are You Sure You Want To Exit?", "Project PICK", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                // The user wants to exit the application
                System.Environment.Exit(1);
            }
            else {
                // Restart the timer.
                timer.Start();

                // Issue the cancel command.
                e.Cancel = true;
            }
                
        }

        /**
         * Called when the user clicks on the logo
         */
        private void Logo_Click(object sender, EventArgs e)
        {
            continueToLogin(null, null);
        }

        /**
         * When the splash page loads we want to set a 5 second timer that
         * will automatically redirect us to the next page.
         */
        private void SplashPage_Load(object sender, EventArgs e)
        {
            
            //Setup our async timer, on the UI Thread.
           // timer.Interval = 3000;
           // timer.Enabled = true;
           // timer.Tick += new EventHandler(continueToLogin);
            //timer.Start();
        }

        private async void continueToLogin(Object myObject, EventArgs myEventArgs)
        {
            // Hides this form
            //this.Hide();

            // Start our next form.
            //LoginPage lp = new LoginPage(dbManager, stateManager);
           // lp.Show();

            // Stop the timer.
           // timer.Stop();
        }

        private void goback_btn1_Click(object sender, EventArgs e)
        {
           // closeProgram = false;

            this.Hide();
            LoginPage sp = new LoginPage(dbManager, stateManager);
            sp.Show();
        }
    }
}