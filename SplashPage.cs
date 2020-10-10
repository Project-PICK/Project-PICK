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

namespace PICKTrainingInc
{
    public partial class SplashPage : Form
    {
        /* Field Variables Here */

        // Used to time when the spash screen should be closed. 
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        /**
         * Constructor, Called when the page is created.
         */
        public SplashPage()
        {
            InitializeComponent();
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
            timer.Interval = 3000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(continueToLogin);
            timer.Start();
        }

#pragma warning disable IDE1006 // Naming Styles
        private async void continueToLogin(Object myObject, EventArgs myEventArgs)
#pragma warning restore IDE1006 // Naming Styles
        {
            // Hides this form
            this.Hide();

            // Start our next form.
            LoginPage lp = new LoginPage();
            lp.Show();

            // Stop the timer.
            timer.Stop();
        }
    }
}
