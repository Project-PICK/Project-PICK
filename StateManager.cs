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
        string trainingName = null;

        /* Constructor */
        public StateManager()
        {
            //do we need to do anything here?
        }

        /* PRIVATE METHODS */

        /* PUBLIC METHODS */

        /**
         * Sets the states username variable
         */
        public void setUserName(string userName)
        {
            this.userName = userName;
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
    }
}