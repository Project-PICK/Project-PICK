/**
 * Program.cs
 * Project-PICK
 * 10/10/2020
 * Authors: Isaac Travers, Candace Moore, Phillip Toulinov, Kyle Smith
 */

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Entity.Core.Objects;
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
            // Start the DB Manager
            DataBaseManager dbManager = new DataBaseManager("Data Source = ../../PICKDataBase.db; Version = 3; New = True; Compress = True; ");
            StateManager stateManager = new StateManager();

            //stateManager.setUserName("admin");
            Application.Run(new SplashPage(dbManager, stateManager));

        }
    }
}
