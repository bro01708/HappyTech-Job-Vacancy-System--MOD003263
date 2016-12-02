using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyTechSystem.DB;
using HappyTechSystem.Core;

namespace HappyTechSystem
{
    /// <summary>
    /// Created by Dan.
    /// UI form to let the user view interview records from the database.
    /// </summary>
    public partial class ViewInterview : Form
    {
        private VacancyBank vacancyBank = VacancyBank.getInst();
        private QuestionBank questionBank = QuestionBank.getInst();
        private string path;

        public ViewInterview()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Created by Dan.
        /// Button event handler to close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_interviews_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qText;
            try
            {
                Interview I = (Interview) lb_interviews.SelectedItem;
                tb_title.Text = I.getApplicantTitle;
                tb_applicantName.Text = I.getApplicantName;
                tb_emailAddress.Text = I.getApplicantEmail;
                tb_interviewerName.Text = I.getInterviewerName;
                tb_notes.Text = I.getAdditionalNotes;
                lbl_score.Text = I.getTotal.ToString();
                path = I.getCVPath;

                List<string> questionsAndRanks = new List<string>(); //final list to display to the textbox
                Vacancy v = vacancyBank.getVacancyList[I.getUsedVacancyID - 1]; //assigns a local vacancy with the vacancy associated with the interview
                int[] questionIDs = v.getQuestionsToBeUsed.ToArray(); //an array of the question IDs that are used by the vacancy
                List<Question> questions = questionBank.getQuestionList; //localised question list


                int index = 0;
                int answerIndex = 0;
                foreach (Question q in questions)
                {
                    if (q.GetID == questionIDs[index])
                    {
                        qText = q.GetText;
                        questionsAndRanks.Add(qText + " - Score: " + I.Answers[answerIndex]);
                        index++;
                        answerIndex++;
                    }
                    
                }
                lb_questionRanks.DataSource = questionsAndRanks;
            }
            catch (Exception)
            {

            }

        }

        private void ViewInterview_Load(object sender, EventArgs e)
        {
            lb_interviews.DataSource = vacancyBank.getInterviewList;
        }

        private void btn_cvOpen_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "The CV file cannot be found at the specified path.\n" +
                    "Ensure it still exists and hasn't been deleted or moved." +
                    "\n\nPath: " + path,
                    "Cannot Open CV");
            }
        }
    }
}
