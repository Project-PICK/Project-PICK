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


namespace PICKTrainingInc
{
    public partial class SplashPage : Form
    {
        public SplashPage()
        {
            InitializeComponent();
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
        }
    }
}
