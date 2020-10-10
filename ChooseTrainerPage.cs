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

        string user;        /* Keeps track of our current user's name */

        /*
         * Constructor
         */
        public ChooseTrainerPage()
        {
            InitializeComponent();
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
    }
}
