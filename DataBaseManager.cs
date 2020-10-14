using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Collections.Specialized;

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
