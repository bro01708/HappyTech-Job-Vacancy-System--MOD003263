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
using HappyTechSystem.DB;

namespace HappyTechSystem
{
    /// <summary>
    /// Created by Dan.
    /// UI Form to support question creation, plugging into the database as necessary.
    /// </summary>
    public partial class CreateQuestion : Form
    {
        private MetaLayer ml = MetaLayer.instance();
        private QuestionBank questionBank = QuestionBank.getInst();

        public CreateQuestion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Created by Dan.
        /// Enables the category management controls, disabling the primary form controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_manageCategories_Click(object sender, EventArgs e)
        {
            gb_question.Enabled = false;
            p_respFeed.Enabled = false;
            gb_category.Enabled = true;
        }

        /// <summary>
        /// Created by Dan
        /// Disables the category manager, re-enabling the primary form controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_categoryDone_Click(object sender, EventArgs e)
        {
            RefreshCategories();
            gb_category.Enabled = false;
            p_respFeed.Enabled = true;
            gb_question.Enabled = true;
        }

        /// <summary>
        /// Created by Dan.
        /// Gives useful information to the user, regarding question creation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_createQuestionHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "To unlock the 'Create Question' button, ensure all fields are filled out, leaving no blanks.",
                "Why is the Create Question button greyed out?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Created by Dan.
        /// Provides helpful information regarding the manage catergories section.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_categoryManagerHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This button will unlock the category manager, which will allow you to create new categories that questions can use.\n" +
                "You can both create new categories and delete pre-existing categories from the toolbox. Click Done when you are finished.",
                "Managing Categories", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Created By peter, Collects the information on the form and gives it to the questionCreator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_createQuestion_Click(object sender, EventArgs e)
        {
            string[] responses =
            {
                tb_response1.Text, tb_response2.Text, tb_response3.Text, tb_response4.Text,
                tb_response5.Text
            };
            string[] feedback =
            {
                tb_feedback1.Text, tb_feedback2.Text, tb_feedback3.Text, tb_feedback4.Text,
                tb_feedback5.Text
            };
            QuestionCreator questionCreator = QuestionCreator.getInst();
            questionCreator.CreateModifyQuestion(Convert.ToInt32(tb_questionID.Text), cb_category.Text,
                tb_questionText.Text, responses, feedback, 0);
            MessageBox.Show(
                "Question Created Successfully!\n\nTo view your question, check the 'View Question Bank' menu!",
                "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CreateQuestion_Load(object sender, EventArgs e)
        {
            int nextID = questionBank.getHighestQuestionID() + 1;
            tb_questionID.Text = nextID.ToString();
            RefreshCategories();
        }

        private void CreateQuestionUnlocker(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(tb_feedback1.Text) ||
                string.IsNullOrEmpty(tb_feedback2.Text) ||
                string.IsNullOrEmpty(tb_feedback3.Text) ||
                string.IsNullOrEmpty(tb_feedback4.Text) ||
                string.IsNullOrEmpty(tb_feedback5.Text) ||
                string.IsNullOrEmpty(tb_response1.Text) ||
                string.IsNullOrEmpty(tb_response2.Text) ||
                string.IsNullOrEmpty(tb_response3.Text) ||
                string.IsNullOrEmpty(tb_response4.Text) ||
                string.IsNullOrEmpty(tb_response5.Text) ||
                string.IsNullOrEmpty(tb_questionText.Text)
            )
            {
                btn_createQuestion.Enabled = false;
            }
            else
            {
                btn_createQuestion.Enabled = true;
            }

        }

        private void CatergoryAddUnlocker(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_addCategory.Text))
            {
                btn_addCategory.Enabled = false;
            }
            else
            {
                btn_addCategory.Enabled = true;
            }
        }

        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            questionBank.getCategoryList.Add(tb_addCategory.Text);
            tb_addCategory.Text = "";
            lbl_addConfimation.Text = "Added Successfully!";
            RefreshCategories();
        }

        private void btn_deleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                questionBank.getCategoryList.Remove(cb_deleteCategory.Text);
                lbl_deleteConfirmation.Text = "Deletion Successful!";
                RefreshCategories();
            }
            catch (Exception)
            {
                lbl_deleteConfirmation.Text = "Deletion Failed!";
                throw;
            }
        }

        private void RefreshCategories()
        {
            cb_category.DataSource = null;
            cb_deleteCategory.DataSource = null;

            cb_category.DataSource = questionBank.getCategoryList;
            cb_deleteCategory.DataSource = questionBank.getCategoryList;
        }

        private void categoryCheck(object sender, EventArgs e)
        {

            if (cb_deleteCategory.Text != "General" && (ml.CheckCategories(cb_deleteCategory.Text) == 0))
            {
                btn_deleteCategory.Enabled = true;
            }
            else
            {
                btn_deleteCategory.Enabled = false;
            }

        }
    }
}

