using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyTechSystem.Core;
using HappyTechSystem.DB;

namespace HappyTechSystem
{
    /// <summary>
    /// Created by Dan.
    /// UI form to help the user conduct an interview.
    /// </summary>
    public partial class ConductInterview : Form
    {
        private VacancyBank vacancyBank;
        private QuestionBank questionBank;
        private MetaLayer ml;
        private List<int> questionsToBeUsed;
        private int[] responses;
        private int vacID;

        public int[] Responses
        {
            get { return responses; }
            set { responses = value; }
        }

        public ConductInterview()
        {
            InitializeComponent();
            questionBank = QuestionBank.getInst();
            vacancyBank = VacancyBank.getInst();
            ml = MetaLayer.instance();
            questionsToBeUsed = new List<int>();

        }
        /// <summary>
        /// Created by Dan.
        /// allows the user to browse for a CV file and paste the file path to the relevant textbox (tb_cvPath).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_browseCV_Click(object sender, EventArgs e)
        {
            int size;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (Exception)
                {
                    {

                    }
                    throw;
                }
                tb_cvPath.Text = file;
            }
        }

        /// <summary>
        /// Created by Peter.
        /// A button to begin the interview. Disables the first panel of controls, and enables the second.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_beginInterview_Click(object sender, EventArgs e)
        {
            vacID = cb_vacancy.SelectedIndex + 1; //necessary adjuster to associate the correct vacancy
            p_setup.Enabled = false;
            p_questions.Enabled = true;

            Vacancy v = (Vacancy)cb_vacancy.SelectedItem;
            questionsToBeUsed = v.getQuestionsToBeUsed;
            responses = new int[questionsToBeUsed.Count];
            tb_questionCount.Text = questionsToBeUsed.Count.ToString();
            tb_questionIndex.Text = "1";
            displayQuestionDetails();
        }

        /// <summary>
        /// Created by Dan.
        /// Helpful infomation for the user regading interview setup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_beginHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To begin the interivew process, you will need to first set-up some interviewee information.\n" +
                            "Make sure all fields are filled out correctly to proceed.\n" +
                            "If the button is still grey, then the vacancy you selected is likely full, and you can no longer conduct any more interviews for it.\n" +
                            "If you wish to interview someone for a vacancy that is full, consider making a new vacancy.", "Why is the 'Begin Interview' button greyed out?", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Created by Dan.
        /// Helpful infomation for the user regarding the interview process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_interviewHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The interview process covers the questions set within the vacancy, beginning with Question 1.\n" +
                            "During the interview, pick a rank based on the quality of the interviewee's response.\n" +
                            "Move through the questions at your own pace, using the 'Previous' and 'Next' buttons.\n" +
                            "Add additional notes if need be, and click 'Complete Interview' when you are finished.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ConductInterviewUnlocker(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(cb_vacancy.Text) ||
                string.IsNullOrEmpty(tb_interviewerName.Text) ||
                string.IsNullOrEmpty(cb_title.Text) ||
                string.IsNullOrEmpty(tb_applicantName.Text) ||
                string.IsNullOrEmpty(tb_email.Text) ||
                string.IsNullOrEmpty(tb_cvPath.Text))
            {
                btn_beginInterview.Enabled = false;
            }
            else
            {
                btn_beginInterview.Enabled = true;
            }
        }

        private void ConductInterview_Load(object sender, EventArgs e)
        {
            cb_vacancy.DataSource = vacancyBank.getVacancyList;
            int nextID = vacancyBank.getHighestInterviewID() + 1;
            tb_interviewID.Text = nextID.ToString();
            tb_interviewerName.Text = MdiParent.Text.Substring(22, MdiParent.Text.Length - 22);
        }

        /// <summary>
        /// created by peter
        /// looks at the index of which question youre currently viewing and updates the boxes accordingly by looking up the index in the questions to be used.
        /// and using that to look up the question ID in the question bank.
        /// </summary>
        private void displayQuestionDetails()
        {
            int questionDisplayIndex = Convert.ToInt32(tb_questionIndex.Text);
            int questionListIndex = questionDisplayIndex - 1;
            int questionID = questionsToBeUsed[questionListIndex];

            Question question = questionBank.getQuestionList.FirstOrDefault(o => o.GetID == questionID);

            tb_questionText.Text = question.GetText;
            tb_rank1.Text = question.Responses[0];
            tb_rank2.Text = question.Responses[1];
            tb_rank3.Text = question.Responses[2];
            tb_rank4.Text = question.Responses[3];
            tb_rank5.Text = question.Responses[4];

            if (tb_questionIndex.Text == tb_questionCount.Text)
            {
                btn_nextQuestion.Enabled = false;
            }
            else if (tb_questionIndex.Text == "1")
            {
                btn_previousQuestion.Enabled = false;
            }
            else
            {
                btn_previousQuestion.Enabled = true;
                btn_nextQuestion.Enabled = true;
            }
            updateRadioButtons(questionListIndex);
        }

        /// <summary>
        /// Created By Peter. 
        /// Advances the question in the interview to the next question id.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_nextQuestion_Click(object sender, EventArgs e)
        {
            if (rb_rank1.Checked || rb_rank2.Checked || rb_rank3.Checked || rb_rank4.Checked || rb_rank5.Checked)
            {
                tb_questionIndex.Text = (Convert.ToInt32(tb_questionIndex.Text) + 1).ToString();
                displayQuestionDetails();
            }
            else { MessageBox.Show("Please select a response to this question before proceeding.", "No Response Given"); }
        }

        private void btn_previousQuestion_Click(object sender, EventArgs e)
        {
            tb_questionIndex.Text = (Convert.ToInt32(tb_questionIndex.Text) - 1).ToString();
            displayQuestionDetails();
        }

        private void setResponseInResponseList(Object sender)
        {
            RadioButton radioButton = (RadioButton)sender;
            int selectedRank = 0;
            int currentQuestion = Convert.ToInt32(tb_questionIndex.Text) - 1;
            switch (radioButton.Name)
            {
                case "rb_rank1":
                    selectedRank = 1;
                    break;
                case "rb_rank2":
                    selectedRank = 2;
                    break;
                case "rb_rank3":
                    selectedRank = 3;
                    break;
                case "rb_rank4":
                    selectedRank = 4;
                    break;
                case "rb_rank5":
                    selectedRank = 5;
                    break;
                default:
                    break;
            }
            responses[currentQuestion] = selectedRank;
            if (tb_questionIndex.Text == tb_questionCount.Text)
            {
                btn_complete.Enabled = true;
            }
        }

        private void rb_rank1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_rank1.Checked)
            {
                setResponseInResponseList(sender);
            }
        }

        private void rb_rank2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_rank2.Checked)
            {
                setResponseInResponseList(sender);
            }
        }

        private void rb_rank3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_rank3.Checked)
            {
                setResponseInResponseList(sender);
            }
        }

        private void rb_rank4_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_rank4.Checked)
            {
                setResponseInResponseList(sender);
            }
        }

        private void rb_rank5_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_rank5.Checked)
            {
                setResponseInResponseList(sender);
            }
        }

        private void updateRadioButtons(int m_currentQuestion)
        {
            if (responses[m_currentQuestion] != 0)
            {
                switch (responses[m_currentQuestion])
                {
                    case 1:
                        rb_rank1.PerformClick();
                        break;
                    case 2:
                        rb_rank2.PerformClick();
                        break;
                    case 3:
                        rb_rank3.PerformClick();
                        break;
                    case 4:
                        rb_rank4.PerformClick();
                        break;
                    case 5:
                        rb_rank5.PerformClick();
                        break;
                    default:
                        break;
                }
            }
            else { rb_rank1.Checked = false; rb_rank2.Checked = false; rb_rank3.Checked = false; rb_rank4.Checked = false; rb_rank5.Checked = false; }
        }

        /// <summary>
        /// Created by Dan
        /// CLicking this complete the interview, passing through relevant information and saving it to the database and elsewhere
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_complete_Click(object sender, EventArgs e)
        {
            InterviewCreator interviewCreator = InterviewCreator.getInst();
            int total = responses.Sum();
            interviewCreator.CreateInterview(Convert.ToInt32(tb_interviewID.Text), vacID, tb_interviewerName.Text, cb_title.Text, tb_applicantName.Text, tb_email.Text, tb_cvPath.Text, tb_notes.Text, responses, total);
            MessageBox.Show("The Interview was successfully recorded!\n\n" +
                            "To view it, check the 'View Interviews' Menu!\n" +
                            "It is also possible to see this interview record attached to its associated vacancy in the 'View Vacancies' menu.",
                            "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
