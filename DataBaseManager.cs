using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Collections.Specialized;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Collections;
using System.Data.Entity.Migrations.Builders;

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

        /**
         * Saves a question to the database, returns the questions id
         */
        public int saveQuestion(string question, string correctAnswer, ArrayList allAnswers, StateManager stateManager, QA_TYPE questionType)
        {
            // check if allAnswers is shorter than 15, if it is, we'll fill it in with blanks
            while (allAnswers.Count < 15) allAnswers.Add("");

            string tquery = "INSERT INTO question (question, correctAnswer, answer1, answer2, answer3, answer4, answer5, answer6, " +
                                                 "answer7, answer8, answer9, answer10, answer11, answer12, answer13, answer14," + 
                                                 "answer15, trainingName  ) VALUES('" + question + "', '" + correctAnswer + "', '" +
                                                 allAnswers[0] + "', '" + allAnswers[1] + "', '" + allAnswers[2] + "', '" +
                                                 allAnswers[3] + "', '" + allAnswers[4] + "', '" + allAnswers[5] + "', '" +
                                                 allAnswers[6] + "', '" + allAnswers[7] + "', '" + allAnswers[8] + "', '" +
                                                 allAnswers[9] + "', '" + allAnswers[10] + "', '" + allAnswers[11] + "', '" +
                                                 allAnswers[12] + "', '" + allAnswers[13] + "', '" + allAnswers[14] + "', '" +
                                                 stateManager.getTrainingName() + "');";
            insert(tquery);

            tquery = "SELECT * from question where question = '"+question+"' AND answer12 = '"+allAnswers[11]+"'; ";
            List<NameValueCollection> idList = query(tquery);


            return int.Parse(idList[0]["id"]);
        }

        public int getUserID(string userName, string password)
        {
            string queryString = "SELECT * from user WHERE userName = '"+userName+"' AND password = '"+password+"'; ";
            List<NameValueCollection> results = query(queryString);

            return int.Parse(results[0]["id"]);
        }

        public bool incrementQuestionDisplay(int userID, int questionID)
        {
            string query = "INSERT INTO user_answers_question(userID, questionID, numDisplay, numAttempt, numCorrect, numWrong) " +
                            " VALUES("+ userID + ", "+questionID+", 1, 0, 0, 0) " +
                            " ON CONFLICT(userID, questionID) " +
                            " DO UPDATE SET numDisplay = numDisplay + 1;";

            return insert(query);
        }

        public bool incrementQuestionAttempt(int userID, int questionID)
        {
            string query = "UPDATE user_answers_question SET numAttempt = numAttempt + 1 WHERE userID = '"+userID+"' AND questionID == '"+questionID+"'; ";
            return insert(query);
        }

        public bool incrementQuestionCorrect(int userID, int questionID)
        {
            string query = "UPDATE user_answers_question SET numCorrect = numCorrect + 1 WHERE userID = '" + userID + "' AND questionID == '" + questionID + "'; ";
            return insert(query);
        }

        public bool incrementQuestionWrong(int userID, int questionID)
        {
            string query = "UPDATE user_answers_question SET numWrong = numWrong + 1 WHERE userID = '" + userID + "' AND questionID == '" + questionID + "'; ";
            return insert(query);
        }

        public List<NameValueCollection> getWorstQuestions(StateManager stateManager, int numQuestions)
        {
            string userName = stateManager.getUserName();
            string trainingName = stateManager.getTrainingName();

            string queryString = "select user.id AS userID, question.id AS questionID, (user_answers_question.numCorrect*1.0 / user_answers_question.numAttempt*1.0) AS pctCorrect, " + 
                                    " numAttempt, numCorrect, numWrong, trainingName, userName, " + 
                                    " question.question, correctAnswer, answer1, answer2, answer3, answer4, answer5, answer6, answer7, " +
                                    " answer8, answer9, answer10, answer11, answer12, answer13, answer14, answer15 " + 
                                    "from user_answers_question, user, question " +
                                    "WHERE user_answers_question.userID = user.id " +
                                    " AND user_answers_question.questionID = question.id " +
                                    " AND pctCorrect NOT NULL " + 
                                    " AND userName = '" + userName + "' " +
                                    " AND trainingName = '" + trainingName + "' " +
                                    " ORDER BY pctCorrect " +
                                    " LIMIT "+numQuestions+"; ";

            return query(queryString);
        }

        public string getRandomQuestionID(StateManager stateManager)
        {
            string queryString = "SELECT question.id AS questionID" +
                                 " FROM question " +
                                 " WHERE trainingName='" + stateManager.getTrainingName() + "'" +
                                 " ORDER BY RANDOM() " +
                                 " LIMIT 1; ";

            List<NameValueCollection> returnVal = query(queryString);
            string questionID = returnVal[0]["questionID"];
            return questionID;
        }


        public int getQuestionAttempts(string questionID)
        {
            string queryString = "select sum(numAttempt) AS totalAttempts from user_answers_question WHERE questionID = '"+questionID+"';";
            List<NameValueCollection> results = query(queryString);
            NameValueCollection result = results[0];

            //Check if result["totalAttempts"] is a blank string
            int numAttempts;

            if(result["totalAttempts"] == "")
            {
                numAttempts = 0;
            }
            else
            {
                numAttempts = int.Parse(result["totalAttempts"]);
            }

            return numAttempts;
        }

        public int getQuestionCorrect(string questionID)
        {
            string queryString = "select sum(numCorrect) AS totalCorrect from user_answers_question WHERE questionID = '" + questionID + "';";
            List<NameValueCollection> results = query(queryString);
            NameValueCollection result = results[0];

            return int.Parse(result["totalCorrect"]);
        }

        public int getQuestionWrong(string questionID)
        {
            string queryString = "select sum(numWrong) AS totalWrong from user_answers_question WHERE questionID = '" + questionID + "';";
            List<NameValueCollection> results = query(queryString);
            NameValueCollection result = results[0];

            return int.Parse(result["totalWrong"]);
        }

        public int getQuestionCorrectByUser(string questionID, int userID)
        {
            string queryString = "SELECT numCorrect FROM user_answers_question WHERE questionID = '"+questionID+"' AND userID = '"+userID+"'";
            List<NameValueCollection> returnVal = query(queryString);
            int numAttempts = 0;
            if (returnVal.Count == 0)
            {
                numAttempts = 0;
            }
            else
            {
                numAttempts = int.Parse(returnVal[0]["numCorrect"]);
            }

            return numAttempts;
        }

        public int getQuestionWrongByUser(string questionID, int userID)
        {
            string queryString = "SELECT numWrong FROM user_answers_question WHERE questionID = '" + questionID + "' AND userID = '" + userID + "'";
            List<NameValueCollection> returnVal = query(queryString);
            int numAttempts = 0;
            if (returnVal.Count == 0)
            {
                numAttempts = 0;
            }
            else
            {
                numAttempts = int.Parse(returnVal[0]["numWrong"]);
            }

            return numAttempts;
        }

        public int getQuestionAttemptsByUser(string questionID, int userID)
        {
            string queryString = "SELECT numAttempt FROM user_answers_question WHERE questionID = '" + questionID + "' AND userID = '" + userID + "'";
            List<NameValueCollection> returnVal = query(queryString);
            int numAttempts = 0;
            if (returnVal.Count == 0)
            {
                numAttempts = 0;
            }
            else
            {
                numAttempts = int.Parse(returnVal[0]["numAttempt"]);
            }

            return numAttempts;
        }

        private void CloseConnection()
        {
            sqlite_conn.Close();
        }

    }
}
