/**
 * MainTrainingPage.cs
 * Project-PICK
 * 10/15/2020
 * Authors: Isaac Travers, Candace Moore, Phillip Toulinov, Kyle Smith
 * 
 * Manages the Main Training Loop
 */

using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;
using System.Collections.Specialized;

namespace PICKTrainingInc
{
    /**
     * Used to allow us to have two types of questions, an image question or a text question
     */
    public enum QA_TYPE
    {
        IMAGE,
        TEXT
    }

    /* *
     * This is our Main Training Form
     */
    public partial class MainTrainingPage : Form
    {
        /* FIELD VARIABLES */
        DataBaseManager dbManager;      /* Used to manage the DB */
        StateManager stateManager;      /* Used to keep track of state */
        Random random;                  /* Generates random numbers. */
        bool closeProgram = true;       /* Are we currently trying to close the program with our button press? */
        Button correctButton = null;    /* Whenever a correct answer is set, the correct button will be here for comparisons. */

        /* CONSTRUCTORS */
        public MainTrainingPage(DataBaseManager dbManager, StateManager stateManager)
        {
            InitializeComponent(); 
            this.dbManager = dbManager;
            this.stateManager = stateManager;
            random  = new Random();
            this.FormClosing += new FormClosingEventHandler(closeForm);
        }

        /* PUBLIC METHODS */


        /* PRIVATE METHODS */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainTrainingPage_Load(object sender, EventArgs e)
        {
            load();
            
        }

        /**
         * Called When the MainTrainingPage is loaded.
         * Generate a question, either from the file system, or from the
         * database, and show that to the user. If a question is generated
         * it is also saved to the database.
         * */
        private void load()
        {
            // Set the welcome label
            lbl_welcome.Text = stateManager.getTrainingName() + " for " + stateManager.getUserName();

            // Load a question for the current training
            loadQuestion();

            
        }

        /**
         * Load's a questions for the current training.
         * Will query the DB for the 10 lowest scored questions in this training that the user has 
         * attempted and randomly choose 1 of the 10. It will then decide whether to show this
         * question to the user again, or to generate a brand new question. With likelyhood
         * 1 - (correctAnswer/totalAnswer)*/
        private void loadQuestion()
        {
            //Get our Worst question to deal with
            List<NameValueCollection> tenWorstQuestions = dbManager.getWorstQuestions(stateManager, 10);

            // If we don't have any questions returned, this means this is the users first question generated, ever!
            if (tenWorstQuestions.Count == 0)
            {
                generateNewQuestion();
                return;
            }

            int index = random.Next(tenWorstQuestions.Count - 1);
            NameValueCollection worstQuestion = tenWorstQuestions[index];

            // Calculate likelyhood of showing this question, vs generating new question
                
            double correctPCT = double.Parse(worstQuestion["pctCorrect"]);
            string correctAnswer = worstQuestion["correctAnswer"];

            // Likelyhood of showing this question is inverse to it's correctPCT
            double likelyhood = 1 - correctPCT;

            double randomDouble = random.NextDouble();

            // showOldQuestion should be true exactly likelyhood% of the time.
            bool showOldQuestion = randomDouble < likelyhood;

            if(showOldQuestion)
            {
                generateOldQuestion(worstQuestion);
            }
            else if(randomDouble > .90) //10% of the time, just choose a random pre-generated question
            {
                string questionID = dbManager.getRandomQuestionID(stateManager);
                generateOldQuestionFromID(questionID);
            }
            else
            {
                generateNewQuestion();
            }
        }

        /**
         * Sets up a question with all answers from the DB, by referencing it's DB ID Number
         * */
        private void generateOldQuestionFromID(string questionID)
        {
            string queryString = "SELECT * from question WHERE id = '"+questionID+"';";
            NameValueCollection question = dbManager.query(queryString)[0];

            string correctAnswer = question["correctAnswer"];
            ArrayList answers = new ArrayList();
            answers.Add(question["answer1"]);
            answers.Add(question["answer2"]);
            answers.Add(question["answer3"]);
            answers.Add(question["answer4"]);
            answers.Add(question["answer5"]);
            answers.Add(question["answer6"]);
            answers.Add(question["answer7"]);
            answers.Add(question["answer8"]);
            answers.Add(question["answer9"]);
            answers.Add(question["answer10"]);
            answers.Add(question["answer11"]);
            answers.Add(question["answer12"]);
            answers.Add(question["answer13"]);
            answers.Add(question["answer14"]);
            answers.Add(question["answer15"]);

            string image = question["question"];

            int correctAnswerPosition = answers.IndexOf(correctAnswer);

            // Setup the gui with the correct questions and answers.
            populateQuestionImage(image);
            populateAnswers(answers, correctAnswerPosition);

            int totalAttempts = dbManager.getQuestionAttempts(question["id"]);
            int totalCorrect = dbManager.getQuestionCorrect(question["id"]);
            int totalWrong = dbManager.getQuestionWrong(question["id"]);
            int numAttempt = dbManager.getQuestionAttemptsByUser(question["id"], stateManager.getUserID());
            int numCorrect = dbManager.getQuestionCorrectByUser(question["id"], stateManager.getUserID());
            int numWrong = dbManager.getQuestionWrongByUser(question["id"], stateManager.getUserID());

            //increment display labels
            currentUserTotal.Text = numAttempt.ToString();
            currentUserCorrect.Text = numCorrect.ToString();
            currentUserWrong.Text = numWrong.ToString();

            allUserCorrect.Text = totalCorrect.ToString();
            allUserTotal.Text = totalAttempts.ToString();
            allUserWrong.Text = totalWrong.ToString();

            gb_stats.Text = "Question Statistics for #id: " + question["id"];

            stateManager.setQuestionID(int.Parse(question["id"]));
            dbManager.incrementQuestionDisplay(stateManager.getUserID(), stateManager.getQuestionID());
        }

        /**
         * Sets the GUI up with a preloaded question.
         * */
        private void generateOldQuestion(NameValueCollection question)
        {
            string correctAnswer = question["correctAnswer"];
            ArrayList answers = new ArrayList();
            answers.Add(question["answer1"]);
            answers.Add(question["answer2"]);
            answers.Add(question["answer3"]);
            answers.Add(question["answer4"]);
            answers.Add(question["answer5"]);
            answers.Add(question["answer6"]);
            answers.Add(question["answer7"]);
            answers.Add(question["answer8"]);
            answers.Add(question["answer9"]);
            answers.Add(question["answer10"]);
            answers.Add(question["answer11"]);
            answers.Add(question["answer12"]);
            answers.Add(question["answer13"]);
            answers.Add(question["answer14"]);
            answers.Add(question["answer15"]);

            string image = question["question"];

            int correctAnswerPosition = answers.IndexOf(correctAnswer);

            // Setup the gui with the correct questions and answers.
            populateQuestionImage(image);
            populateAnswers(answers, correctAnswerPosition);

            int totalAttempts = dbManager.getQuestionAttempts(question["questionID"]);
            int totalCorrect = dbManager.getQuestionCorrect(question["questionID"]);
            int totalWrong = dbManager.getQuestionWrong(question["questionID"]);

            //increment display labels
            currentUserTotal.Text = question["numAttempt"];
            currentUserCorrect.Text = question["numCorrect"];
            currentUserWrong.Text = question["numWrong"];

            allUserCorrect.Text = totalCorrect.ToString(); 
            allUserTotal.Text = totalAttempts.ToString();
            allUserWrong.Text = totalWrong.ToString();
            gb_stats.Text = "Question Statistics for #id: " + question["questionID"];

            
            stateManager.setQuestionID(int.Parse(question["questionID"]));
            dbManager.incrementQuestionDisplay(stateManager.getUserID(), stateManager.getQuestionID());
        }

        /**
         * Generates a new question and all related answers from the file system
         * displays question and saves to database.
         * */
        private void generateNewQuestion()
        {
            //Load the question and answers
            string[] answerAndImage = getRandomQuestionImage();
            string correctAnswer = answerAndImage[0];

            string image = answerAndImage[1];
            ArrayList answers = getRandomWrongAnswers(correctAnswer);

            int correctAnswerPosition = random.Next(answers.Count-1);
            answers.Insert(correctAnswerPosition, correctAnswer); //TODO: Argument out of range exception

            // Setup the gui with the correct questions and answers.
            populateQuestionImage(image);
            populateAnswers(answers, correctAnswerPosition);

            //set labels
            //increment display labels
            currentUserTotal.Text = "0";
            currentUserCorrect.Text = "0";
            currentUserWrong.Text = "0";
            allUserCorrect.Text = "0";
            allUserTotal.Text = "0";
            allUserWrong.Text = "0";

            int questionID = dbManager.saveQuestion(image, correctAnswer, answers, stateManager, QA_TYPE.IMAGE);
            stateManager.setQuestionID(questionID);
            gb_stats.Text = "Question Statistics for #id: " + questionID;

            dbManager.incrementQuestionDisplay(stateManager.getUserID(), stateManager.getQuestionID());
        }

        /**
         * Loads our media with the appropriate question image 
         * */
        private void populateQuestionImage(string imageLocation)
        {
            pb_question.Image = Image.FromFile(imageLocation);
        }

        /**
         * Populate our answers button with the array of answers, and record
         * where the correct position is
         */
        private void populateAnswers(ArrayList answers, int correctAnswerPosition)
        {
            tbl_answers.Controls.Clear();
            //hide our default button
            button1.Hide();

            int i = 0;
            foreach(string answer in answers)
            {
                addButton(answer, i == correctAnswerPosition);
                i++;
            }
        }

        /**
         * Add an answer button to the screen, is it the correct button? 
         */
        private void addButton(string buttonText, bool markAsCorrect)
        {
            Button b = new Button();
            b.Text = buttonText;
            b.Size = new Size(150, 50);
            b.Click += button_Click;
            b.Font = new Font(b.Font.FontFamily, 8, FontStyle.Bold);
            tbl_answers.Controls.Add(b);

            // If this is the button to the correct answer, save it for comparison.
            if (markAsCorrect) correctButton = b;
        }

        /*
         * Read a list of possible wrong answers into an array
         * */
        private ArrayList getRandomWrongAnswers(string correctAnswer)
        {
            string trainingName = stateManager.getTrainingName();
            string dirName = @"..\..\TrainingData\" + trainingName;
            string[] dirNames = Directory.GetDirectories(dirName);
            ArrayList cleanDirNames = new ArrayList();

            //remove path and underscores
            foreach(string n in dirNames)
            {
                string temp = n.Substring(n.LastIndexOf("\\") + 1);
                temp = temp.Replace("_", " ");
                cleanDirNames.Add(temp);
            }

            //TODO build wrong answer array
            //string correctName = dirName + @"\" + correctAnswer;

            ArrayList wrongAnswers = new ArrayList();
            
            foreach(string candidateName in cleanDirNames)
            {
                if (candidateName != correctAnswer)
                {
                    wrongAnswers.Add(candidateName);
                }
            }

            //choose a random number 11 times 
            while(wrongAnswers.Count >= 15)
            {
                int indexToRemove = random.Next(0, wrongAnswers.Count - 1);
                wrongAnswers.RemoveAt(indexToRemove);
            }

            return wrongAnswers;
        }
    
        /**
         * Returns a random image from our current training set to be used as a question.
         * */
        private string[] getRandomQuestionImage()
        {
            
            string trainingName = stateManager.getTrainingName();
            string dirName = @"..\..\TrainingData\" + trainingName;
            string[] dirNames = Directory.GetDirectories(dirName);

            int randIndex = random.Next(dirNames.Length - 1);

            string answerDir = dirNames[randIndex];
            string[] answerNamesInDir = Directory.GetFiles(dirName);

            string[] allQuestions = Directory.GetFiles(answerDir);

            randIndex = random.Next(allQuestions.Length - 1);

            string randImage = allQuestions[randIndex];

            answerDir = answerDir.Substring(answerDir.LastIndexOf("\\") + 1);
            answerDir = answerDir.Replace("_", " ");
            string[] returnVal = { answerDir, randImage };

            return returnVal;
        }

        /**
         * Called When the user tries to close the form
         */
        private void closeForm(Object sender, FormClosingEventArgs e)
        {

            // Only prompt the user if we are pressing the close button.
            if (closeProgram)
            {
                // Show a dialog box.
                DialogResult d = MessageBox.Show("Are You Sure You Want To Exit?", "Project PICK", MessageBoxButtons.YesNo);
                if (d == DialogResult.No)
                {

                    // Issue the cancel command.
                    e.Cancel = true;
                }
                else
                {
                    closeProgram = true;
                    System.Environment.Exit(1);
                }
            }

        }

        /**
         * Called when user clicks the "go back" button.
         * */
        private void goback_btn_Click(object sender, EventArgs e)
        {
            closeProgram = false;

            this.Close();
            ChooseTrainerPage tp = new ChooseTrainerPage(dbManager, stateManager);
            tp.Show();
        }

        /**
         *  Causes a given button to blink a given color the given number of times
         *  then causes the form to reload when done blinking, or not.
         *  */
        private async void blinkButton(Button b, Color colorToBlink, int numTimes, bool reloadForm)
        {
            if (numTimes == 0) numTimes = 999999999;


            Color backColor = b.BackColor;
            Color foreColor = b.ForeColor;
            for(int i = 0; i < numTimes; i ++)
            {
                await Task.Delay(150);

                // Blink the button.
                if (b.BackColor == backColor)
                {
                    b.BackColor = colorToBlink;
                }
                else
                {
                    b.BackColor = backColor;
                }
            }

            if (reloadForm)
            {
                statusStrip1.Text = "Loading Next Question Now...";
                await Task.Delay(2000);
                load();
            }
        }

        /**
         * Grays out all the answer buttons so they are no longer clickable
         */
        private void grayAllAnswers()
        {
            foreach(Button b in tbl_answers.Controls)
            {
                b.Enabled = false;
            }
        }

        /**
         * Records the fact that the user just answered this question correctly
         * to the database.
         */
        void recordCorrectQuestion()
        {
            dbManager.incrementQuestionAttempt(stateManager.getUserID(), stateManager.getQuestionID());
            dbManager.incrementQuestionCorrect(stateManager.getUserID(), stateManager.getQuestionID());

            //increment display labels
            int total = int.Parse(currentUserTotal.Text);
            total = total + 1;
            currentUserTotal.Text = total.ToString();

            total = int.Parse(currentUserCorrect.Text);
            total = total + 1;
            currentUserCorrect.Text = total.ToString();

            //increment display labels
            total = int.Parse(allUserTotal.Text);
            total = total + 1;
            allUserTotal.Text = total.ToString();

            total = int.Parse(allUserCorrect.Text);
            total = total + 1;
            allUserCorrect.Text = total.ToString();
        }

        /**
        * Records the fact that the user just answered this question wrong
        * to the database.
        */
        void recordWrongQuestion()
        {
            dbManager.incrementQuestionAttempt(stateManager.getUserID(), stateManager.getQuestionID());
            dbManager.incrementQuestionWrong(stateManager.getUserID(), stateManager.getQuestionID());

            //increment display labels
            int total = int.Parse(currentUserTotal.Text);
            total = total + 1;
            currentUserTotal.Text = total.ToString();

            total = int.Parse(currentUserWrong.Text);
            total = total + 1;
            currentUserWrong.Text = total.ToString();

            //increment display labels
            total = int.Parse(allUserTotal.Text);
            total = total + 1;
            allUserTotal.Text = total.ToString();

            total = int.Parse(allUserWrong.Text);
            total = total + 1;
            allUserWrong.Text = total.ToString();
        }

        /**
         * The user just answered this question correct, we want to send the user
         * feedback, record this, and load the next question. */
        void setQuestionAnsweredCorrect(Button b)
        {
            //gray out all buttons
            grayAllAnswers();

            //We'll record this to the database
            recordCorrectQuestion();

            //We'll give the user feedback by setting the status.
            toolStripStatusLabel1.Text = "Question answered CORRECT! Loading Next Question...";

            //And we'll blink a button Green
            blinkButton(b, Color.Green, 11, true);
        }

        /**
         * The user just answered this question wrong. Do the things needed
         */
        void setQuestionAnsweredWrong(Button b)
        {
            //Record this to the Database
            recordWrongQuestion();

            //Give user feeback with status strip and red button
            toolStripStatusLabel1.Text = "Question answered Wrong! Loading Next Question...";

            //And we'll blink a button Green
            blinkButton(b, Color.Red, 9, false);

        }

        /* Checks if the given button is infact the button for
         * the correct answer.
         * */
        
        bool isCorrectAnswer(Button b)
        {
            return correctButton == b;
        }

        /**
         * Called when an answer button is clicked.
         * */
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Enabled = false;

            if (isCorrectAnswer(b))
            {
                setQuestionAnsweredCorrect(b);
            }
            else
            {
                setQuestionAnsweredWrong(b);
            }
            
        }

        private void goback_Click(object sender, EventArgs e)
        {
            closeProgram = false;

            this.Close();
            ChooseTrainerPage tp = new ChooseTrainerPage(dbManager, stateManager);
            tp.Show();
        }
    }
}