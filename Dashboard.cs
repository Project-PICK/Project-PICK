/**
 * The Dashboard will show the user all their stats
 * and will show the administrator ALL user stats
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
    public partial class Dashboard : Form
    {
        /* Field Variables and Objects */
        DataBaseManager dbManager;      /* Used to manage the DB */
        StateManager stateManager;      /* Used to keep track of state */
        bool closeProgram = true;       /* Are we currently trying to close the program with our button press? */

        /**
         * Constructor
         * */
        public Dashboard(DataBaseManager dbManager, StateManager sManager)
        {
            InitializeComponent();
            this.dbManager = dbManager;
            stateManager = sManager;
            
           // setUserInfo(stateManager.getUserID());
        }

        /**
         * Sets the userinto when loaded
         * */

        private void setUserInfo(int userID)
        {
            NameValueCollection user = dbManager.getUserByID(userID);
            tb_userName.Text = user["userName"];
            tbFirstName.Text = user["firstName"];
            tbLastName.Text = user["lastName"];
            tbPassword.Text = user["password"];
            string str_isAdmin = user["isAdmin"];

            bool isAdmin;

            if (str_isAdmin == "")
            {
                isAdmin = false;
            }
            else
            {
                isAdmin = bool.Parse(user["isAdmin"]);
            }
            cbIsAdmin.Checked = isAdmin;
            cbIsAdmin.Enabled = stateManager.isAdmin();
        }

        /**
         * Sets the initial title of the page
         */
        private void setTitle()
        {
            string title = stateManager.getUserName() + "'s ";

            //Usernames [Admin] Dashboard.
            if (stateManager.isAdmin()) title += "[ADMIN] ";

            title += " Dashboard ";

            this.Text = title;
        }

        /**
         * User clicked exit button on menu
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
         * User Clicked "choose training" on menu.
         * */
        private void chooseTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeProgram = false;

            this.Close();
            ChooseTrainerPage lp = new ChooseTrainerPage(dbManager, stateManager);
            lp.Show();
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            setTitle();
            setUserInfo(stateManager.getUserID());
        }

        private void currentUser_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void goback_btn1_Click(object sender, EventArgs e)
        {
            closeProgram = false;

            this.Close();
            ChooseTrainerPage sp = new ChooseTrainerPage(dbManager, stateManager);
            sp.Show();
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

        private void gb_questionsAnswered_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
