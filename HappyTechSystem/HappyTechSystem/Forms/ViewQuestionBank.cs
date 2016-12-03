using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyTechSystem.Core;

namespace HappyTechSystem
{
    /// <summary>
    /// Created by Dan.
    /// UI form to allow the user to view all questions stored in the database.
    /// </summary>
    public partial class ViewQuestionBank : Form
    {
        private QuestionBank questionBank = QuestionBank.getInst();
        private VacancyBank vacancyBank = VacancyBank.getInst();
        //private variable used to aid toggling
        private byte flag;

        public ViewQuestionBank()
        {
            InitializeComponent();
            lb_Q.DataSource = questionBank.getQuestionList;
            RefreshFilters();
        }

        /// <summary>
        /// Created by Dan.
        /// button event handler that saves any edited question to the database by altering the records.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Save Question Changes?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    string[] responses = { tb_response1.Text, tb_response2.Text, tb_response3.Text, tb_response4.Text, tb_response5.Text };
                    string[] feedback = { tb_feedback1.Text, tb_feedback2.Text, tb_feedback3.Text, tb_feedback4.Text, tb_feedback5.Text };
                    QuestionCreator questionCreator = QuestionCreator.getInst();
                    questionCreator.ModifyQuestion(Convert.ToInt32(tb_questionID.Text), cb_categoryTag.Text, tb_question.Text, responses, feedback);
                    MessageBox.Show("The question was edited successfully.\n\n" +
                                    "For the new changes to load, the form needs to reload.\n" +
                                    "Open Question Bank again to view changes.", "Edit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    questionBank.RefreshDBConnection();
                    this.Close();
                }
            }
            catch (Exception err)
            {
                
                throw err;
            }
        }

        /// <summary>
        /// Created by Dan.
        /// This button event handler enables most of the read-only fields, allowing them to be editing temporarily.
        /// A flag is used to act as a button toggle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_Click(object sender, EventArgs e)
        { 

            if (flag == 0)
            {
                p_editToolbox.Enabled = true;
                lb_Q.Enabled = false;
                btn_close.Enabled = false;
                cb_categoryTag.Enabled = true;
                cb_categoryTag.DataSource = questionBank.getCategoryList;
                tb_question.ReadOnly = false;
                tb_feedback1.ReadOnly = false;
                tb_feedback2.ReadOnly = false;
                tb_feedback3.ReadOnly = false;
                tb_feedback4.ReadOnly = false;
                tb_feedback5.ReadOnly = false;
                tb_response1.ReadOnly = false;
                tb_response2.ReadOnly = false;
                tb_response3.ReadOnly = false;
                tb_response4.ReadOnly = false;
                tb_response5.ReadOnly = false;
                flag++;
            }
            else
            {
                p_editToolbox.Enabled = false;
                lb_Q.Enabled = true;
                btn_close.Enabled = true;
                cb_categoryTag.Enabled = false;
                tb_question.ReadOnly = true;
                tb_feedback1.ReadOnly = true;
                tb_feedback2.ReadOnly = true;
                tb_feedback3.ReadOnly = true;
                tb_feedback4.ReadOnly = true;
                tb_feedback5.ReadOnly = true;
                tb_response1.ReadOnly = true;
                tb_response2.ReadOnly = true;
                tb_response3.ReadOnly = true;
                tb_response4.ReadOnly = true;
                tb_response5.ReadOnly = true;
                flag--;
            }
        }

        /// <summary>
        /// Created by Dan.
        /// When the form loads, the edit tool box is disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewQuestionBank_Load(object sender, EventArgs e)
        {
            p_editToolbox.Enabled = false;

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

        private void lb_Q_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearFields();

            try
            {
                Question q = (Question)lb_Q.SelectedItem;
                tb_question.Text = q.GetText;
                tb_questionID.Text = q.GetID.ToString();
                cb_categoryTag.Text = q.GetTag;
                tb_response1.Text = q.Responses[0];
                tb_response2.Text = q.Responses[1];
                tb_response3.Text = q.Responses[2];
                tb_response4.Text = q.Responses[3];
                tb_response5.Text = q.Responses[4];

                tb_feedback1.Text = q.Feedback[0];
                tb_feedback2.Text = q.Feedback[1];
                tb_feedback3.Text = q.Feedback[2];
                tb_feedback4.Text = q.Feedback[3];
                tb_feedback5.Text = q.Feedback[4];
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Created by Peter.
        /// Handles deletion of a particular question, checking whether or not it's still bound to a vacancy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Question q = (Question)lb_Q.SelectedItem;
                int associatedQuestions = 0;

                foreach (Vacancy v in vacancyBank.getVacancyList)
                {
                    int index = 0;
                    foreach (int qID in v.getQuestionsToBeUsed)
                    {
                        if (v.getQuestionsToBeUsed[index] == q.GetID)
                        {
                            associatedQuestions++;
                        }
                        index++;
                    }
                }
                if (associatedQuestions == 0)
                {
                    DialogResult dialogResult =  MessageBox.Show("You are about to delete this question, including all of it's criteria and feedback information." +
                                    "\n\nAre you sure you want to delete this question?","Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        questionBank.removeFromList(Convert.ToInt32(tb_questionID.Text));
                        lb_Q.DataSource = null;
                        lb_Q.DataSource = questionBank.getQuestionList;
                        try
                        {
                            btn_edit.PerformClick();
                            lb_Q.SelectedIndex = 0;
                        }
                        catch (Exception)
                        {
                            clearFields();
                        }

                        MessageBox.Show("Question Successfully Deleted.", "Deletion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You cannot delete this question due to the following reasons:" +
                                    "\n\n(X) This question is still bound to a Vacancy.", "Cannot Delete Question", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private void cb_filterCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_filterCategories.Text == "All")
            {
                lb_Q.DataSource = questionBank.getQuestionList;
            }
            else
            {
                lb_Q.DataSource = questionBank.getQuestionList.Where(q => q.GetTag == cb_filterCategories.Text).ToList();
            }
        }
        private void RefreshFilters()
        {
            List<string> filters = new List<string>();
            filters.Insert(0, "All");
            filters.AddRange(questionBank.getCategoryList);
            cb_filterCategories.DataSource = filters;
        }

        /// <summary>
        /// Created by Dan.
        /// Flushes all fields, replacing them with empty strings.
        /// </summary>
        private void clearFields()
        {
            tb_question.Text = "";
            tb_questionID.Text = "";
            cb_categoryTag.Text = "";
            tb_response1.Text = "";
            tb_response2.Text = "";
            tb_response3.Text = "";
            tb_response4.Text = "";
            tb_response5.Text = "";
            tb_feedback1.Text = "";
            tb_feedback2.Text = "";
            tb_feedback3.Text = "";
            tb_feedback4.Text = "";
            tb_feedback5.Text = "";
        }

        /// <summary>
        /// Created By Dan. 
        /// Unlocks the save changes button if all fields arent empty
        /// </summary>
        private void saveUnlocker(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_question.Text) ||
                string.IsNullOrEmpty(tb_response1.Text) ||
                string.IsNullOrEmpty(tb_response2.Text) ||
                string.IsNullOrEmpty(tb_response3.Text) ||
                string.IsNullOrEmpty(tb_response4.Text) ||
                string.IsNullOrEmpty(tb_response5.Text) ||
                string.IsNullOrEmpty(tb_feedback1.Text) ||
                string.IsNullOrEmpty(tb_feedback2.Text) ||
                string.IsNullOrEmpty(tb_feedback3.Text) ||
                string.IsNullOrEmpty(tb_feedback4.Text) ||
                string.IsNullOrEmpty(tb_feedback5.Text)
                )
            {
                btn_save.Enabled = false;
            }
            else
            {
                btn_save.Enabled = true;
            }
        }
    }
}