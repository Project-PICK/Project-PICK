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

namespace PICKTrainingInc
{
    public partial class MainTrainingPage : Form
    {

        /* FIELD VARIABLES */
        DataBaseManager dbManager;
        StateManager stateManager;
        Random random;
        bool closeProgram = true;
        Button correctButton = null; //Whenever a correct answer is set, the correct button will be here for comparisons.

        int TOTAL_ANSWERS = 15;

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

        private void load()
        {
            //Set the welcome label
            lbl_welcome.Text = stateManager.getTrainingName() + " for " + stateManager.getUserName();
            string[] answerAndImage = getRandomQuestionImage();
            string correctAnswer = answerAndImage[0];

            string image = answerAndImage[1];
            ArrayList answers = getRandomWrongAnswers(correctAnswer);
            int correctAnswerPosition = random.Next(TOTAL_ANSWERS);
            answers.Insert(correctAnswerPosition, correctAnswer); //TODO: Argument out of range exception

            populateQuestionImage(image);
            populateAnswers(answers, correctAnswerPosition);

            
        }

        /**
         * Loads our media with the appropriate question image 
         * */
        private void populateQuestionImage(string imageLocation)
        {
            pb_question.Image = Image.FromFile(imageLocation);
        }

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

        private void addButton(string buttonText, bool markAsCorrect)
        {
            Button b = new Button();
            b.Text = buttonText;
            b.Size = new Size(150, 50);
            b.Click += button_Click;
            tbl_answers.Controls.Add(b);

            // If this is the button to the correct answer, save it for comparison.
            if (markAsCorrect) correctButton = b;
        }

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
            string answerDir = dirNames[random.Next(dirNames.Length-1)];
            string[] fileNamesInDir = Directory.GetFiles(dirName);

            string randImage = Directory.GetFiles(answerDir)[random.Next(fileNamesInDir.Length-1)];

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

        private void goback_btn_Click(object sender, EventArgs e)
        {
            closeProgram = false;

            this.Close();
            ChooseTrainerPage tp = new ChooseTrainerPage(dbManager, stateManager);
            tp.Show();
        }

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
         * Records the fact that the user just answered this question correctly
         * to the database.
         */
        void recordCorrectQuestion()
        {
            //TODO
        }

        /**
        * Records the fact that the user just answered this question wrong
        * to the database.
        */
        void recordWrongQuestion()
        {
            //TODO
        }

        /**
         * The user just answered this question correct, we want to send the user
         * feedback, record this, and load the next question. */
        void setQuestionAnsweredCorrect(Button b)
        {
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
    }
}