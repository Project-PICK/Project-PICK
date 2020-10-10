using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICKTrainingInc
{
    public partial class ChooseTrainerPage : Form
    {

        /* Field Variables */

        // Used to deside if the user is trying to close the program
        // we assume if the program is being closed, the user wants to exit
        // unless the submit button gets hit, then the user doesn't want
        // to exit the whole program.
        bool closeProgram = true;
        string user;        /* Keeps track of our current user's name */

        /*
         * Constructor
         */
        public ChooseTrainerPage()
        {
            InitializeComponent();
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
            user = getUser();
            setName(user);
        }

        /* Returns the name of the currently logged in user */
        private string getUser(){
            //TODO: Implement actual getUser

            return "Test User";
        }

        /* Sets the username for the current form */
        private void setName(string name)
        {
            chooseTrainingLabel.Text = "Hello " + name + ", \nPlease Choose Your Training Course!";

        }

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
    }
}
