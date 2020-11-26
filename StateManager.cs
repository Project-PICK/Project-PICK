/**
 * StateManager.cs
 * Project-PICK
 * 10/10/2020
 * Authors: Isaac Travers, Candace Moore, Phillip Toulinov, Kyle Smith
 * 
 * Manages the state of the application at any given point.
 */

namespace PICKTrainingInc
{
    public class StateManager
    {
        /* FIELD VARIABLES */
        string userName = null;
        string firstName = null;
        string lastName = null;
        string password = null;
        private bool isAnAdmin = false;
        int userID = -1; //the userID of this user as it is in the DB
        int questionID = -1; //the questionID of the last question asked.
        string trainingName = null; //the current training name 
        DataBaseManager dbManager;

        /* Constructor */
        public StateManager(DataBaseManager dbManager)
        {
            this.dbManager = dbManager;
        }

        /* PRIVATE METHODS */

        /* PUBLIC METHODS */

        /**
         * Sets the states username variable
         */
        public void setUserName(string userName, string password)
        {
            // Set the Username
            this.userName = userName;

            // Get the users ID from the DB
            int userID = dbManager.getUserID(userName, password);

            // And save that userID
            setUserID(userID);
        }

        /*
         * Gives the current username.
         */
        public string getUserName()
        {
            return userName;
        }

        /*
         * Returns the current training name
         */
        public string getTrainingName()
        {
            return trainingName;
        }

        /**
         * Sets the states current training name
         * */
        public void setTrainingName(string trainingName)
        {
            this.trainingName = trainingName;
        }

        /**
         * Set the states current user ID
         */
        public void setUserID(int userID)
        {
            this.userID = userID;
        }

        /**
         * Returns the current user id
         */
        public int getUserID()
        {
            return userID;
        }

        /**
         * Set the states current questionID ID
         */
        public void setQuestionID(int questionID)
        {
            this.questionID = questionID;
        }

        /**
         * Returns the current user id
         */
        public int getQuestionID()
        {
            return questionID;
        }

        public void setIsAdmin(bool isAnAdmin)
        {
            this.isAnAdmin = isAnAdmin;
        }

        public bool isAdmin()
        {
            return isAnAdmin;
        }

        public void setFirstName(string name)
        {
            this.firstName = name;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public void setLastName(string name)
        {
            this.lastName = name;
        }

        public string getLastName()
        {
            return lastName;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPassword()
        {
            return password;
        }


    }
}