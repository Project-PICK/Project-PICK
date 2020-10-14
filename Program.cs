using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PICKTrainingInc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataBaseManager dbManager = new DataBaseManager("Data Source = ../../PICKDataBase.db; Version = 3; New = True; Compress = True; ");
            List <NameValueCollection> queryResult; // = new NameValueCollection();
           // queryResult = dbManager.query("SELECT * FROM user");
            //Console.WriteLine(queryResult[0]["userName"]);
            //Application.Run(new PICKTrainingInc.prototypes.isaac.Form1());
            //Application.Run(new MainTrainingPage());
            //Application.Run(new LoginPage(dbManager));
            Application.Run(new SplashPage());
            Application.Run(new SplashPage());
            /*
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             //Application.Run(new AdminConsole());
             Application.Run(new SplashPage());
             //Application.Run(new LoginPage());
             */
        }
    }
}
