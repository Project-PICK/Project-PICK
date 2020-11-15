/**
 * The Dashboard will show the user all their stats
 * and will show the administrator ALL user stats
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
    public partial class Dashboard : Form
    {
        /* Field Variables and Objects */
        DataBaseManager databaseManager;
        StateManager stateManager;

        /**
         * Constructor
         * */
        public Dashboard(DataBaseManager dbManager, StateManager sManager)
        {
            InitializeComponent();
            databaseManager = dbManager;
            stateManager = sManager;
        }
    }
}
