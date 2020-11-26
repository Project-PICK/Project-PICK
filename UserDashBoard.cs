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
    public partial class UserDashBoard : Form
    {
        /* Field Variables and Object */
        protected DataBaseManager databaseManager;
        protected StateManager stateManager;

        /**
         * Consltructor
         * */
        public UserDashBoard(DataBaseManager dbManager, StateManager sManager)
        {
            InitializeComponent();
            databaseManager = dbManager;
            stateManager = sManager;
        }

        private void userInfoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
