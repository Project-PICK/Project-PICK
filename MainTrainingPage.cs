/**
 * MainTrainingPage.cs
 * Project-PICK
 * 10/15/2020
 * Authors: Isaac Travers, Candace Moore, Phillip Toulinov, Kyle Smith
 * 
 * Manages the Main Training Loop
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

namespace PICKTrainingInc
{
    public partial class MainTrainingPage : Form
    {

        /* FIELD VARIABLES */
        DataBaseManager dbManager;
        StateManager stateManager;
        bool closeProgram = true;

        /* CONSTRUCTORS */
        public MainTrainingPage(DataBaseManager dbManager, StateManager stateManager)
        {
            InitializeComponent();
            this.dbManager = dbManager;
            this.stateManager = stateManager;
        }

        /* PUBLIC METHODS */


        /* PRIVATE METHODS */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainTrainingPage_Load(object sender, EventArgs e)
        {
            //Set the welcome label
            lbl_welcome.Text = stateManager.getTrainingName() + " for " + stateManager.getUserName();
        }

        /**
         * Called When the user tries to close the form
         */
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

        private void goback_btn_Click(object sender, EventArgs e)
        {
            closeProgram = false;

            this.Close();
            ChooseTrainerPage tp = new ChooseTrainerPage(dbManager, stateManager);
            tp.Show();
        }
    }
}
