using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Collections.Specialized;
using System.Runtime.InteropServices.WindowsRuntime;

namespace PICKTrainingInc
{

    public class DataBaseManager
    {
        /* Field Variables */ 
        SQLiteConnection sqlite_conn;

        public DataBaseManager(string connectionString)
        {
            sqlite_conn = CreateConnection(connectionString);

        }

        private SQLiteConnection CreateConnection(string connectionString)
        {
            sqlite_conn = new SQLiteConnection(connectionString);
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }
        //List<int> termsList = new List<int>();

        /*
         * Initiates an Insert Command on the Database, returns true if an insert occured.
         */
        public bool insert(string insertText)
        {
            // Setup our return Variable
            bool returnVal = false;

            // Setup the command
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = insertText;

            
            // Variable to check if insert works
            int numUpdated = 0;

            try
            {
                // Execute the insert
                numUpdated = sqlite_cmd.ExecuteNonQuery();
            }
            catch(System.Data.SQLite.SQLiteException e)
            {
                // Insert did not work.
                numUpdated = 0;
            }
            

            // Check if we updated any lines
            if(numUpdated > 0)
            {
                returnVal = true;
            }
            else
            {
                returnVal = false;
            }

            return returnVal;
        }

        public List<NameValueCollection> query(string queryText)
        {
            // NameValueCollection[] returnVal = { };
            List<NameValueCollection> returnVal = new List<NameValueCollection>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = queryText;


            sqlite_datareader = sqlite_cmd.ExecuteReader();

            
            while (sqlite_datareader.Read())
            {
                //Setup the name value collection to save the row in
                NameValueCollection row = new NameValueCollection();
                int numFields = sqlite_datareader.FieldCount;
                
                //loop through the fields
                for(int i = 0; i < numFields; i++)
                {
                    string fieldName = sqlite_datareader.GetName(i);
                    string dataTypeName = sqlite_datareader.GetDataTypeName(i);
                    object data = sqlite_datareader.GetValue(i);
                    row[fieldName] = data.ToString();
                    row["dataType"] = dataTypeName;
                }
                //string columnName = sqlite_datareader.GetName(0);

                // sqlite_datareader.
                // string myreader = sqlite_datareader.GetDataTypeName(0);
                //Console.WriteLine(myreader);
                //returnVal.Append(row);
                returnVal.Add(row);
                
            }
            return returnVal;
            //conn.Close();
        }

        private void CloseConnection()
        {
            sqlite_conn.Close();
        }

    }
}
