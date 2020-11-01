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

        int TOTAL_ANSWERS = 16;

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
            //Set the welcome label
            lbl_welcome.Text = stateManager.getTrainingName() + " for " + stateManager.getUserName();
            string[] answerAndImage = getRandomQuestionImage();
            string correctAnswer = answerAndImage[0];

            string image = answerAndImage[1];
            ArrayList answers = getRandomWrongAnswers(correctAnswer);
            int correctAnswerPosition = random.Next(TOTAL_ANSWERS);
            answers.Insert(correctAnswerPosition, correctAnswer); //TODO: Argument out of range exception

            populateQuestionImage(image);
            populateAnswers(answers);
            
        }

        /**
         * Loads our media with the appropriate question image 
         * */
        private void populateQuestionImage(string imageLocation)
        {
            pb_question.Image = Image.FromFile(imageLocation);
        }

        private void populateAnswers(ArrayList answers)
        {
            //hide our default button
            button1.Hide();


            foreach(string answer in answers)
            {
                addButton(answer);
            }
        }

        private void addButton(string buttonText)
        {
            Button b = new Button();
            b.Text = buttonText;
            b.Size = new Size(150, 50);
            tbl_answers.Controls.Add(b);
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
    
        private string[] getRandomQuestionImage()
        {
            
            string trainingName = stateManager.getTrainingName();
            string dirName = @"..\..\TrainingData\" + trainingName;
            string[] dirNames = Directory.GetDirectories(dirName);
            string answerDir = dirNames[random.Next(dirNames.Length-1)];
            
            

            string randImage = Directory.GetFiles(answerDir)[random.Next(dirNames.Length-1)];

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
    }
}
