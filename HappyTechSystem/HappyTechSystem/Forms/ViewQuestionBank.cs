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
        //private variable used to aid toggling
        private byte flag;

        public ViewQuestionBank()
        {
            InitializeComponent();
            lb_Q.DataSource = questionBank.getQuestionList;

            //foreach (Question question in QuestionBank.getInst().getQuestionList)
            //{
            //    lb_Q.Items.Add(question);
            //}
        }

        /// <summary>
        /// Created by Dan.
        /// button event handler that saves any edited question to the database by altering the records.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {

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
                tb_categoryTag.ReadOnly = false;
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
                tb_categoryTag.ReadOnly = true;
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
            try
            {
                Question q = (Question)lb_Q.SelectedItem;
                tb_question.Text = q.GetText;
                tb_questionID.Text = q.GetID.ToString();
                tb_categoryTag.Text = q.GetTag;
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
                //MessageBox.Show("Please click an entry in the textbox" + " " + ex.ToString());
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                questionBank.removeFromList(Convert.ToInt32(tb_questionID.Text));
                lb_Q.DataSource= null;
                lb_Q.DataSource = questionBank.getQuestionList;
                try
                {
                    
                    btn_edit.PerformClick();
                    lb_Q.SelectedIndex = 0;
                }
                catch (Exception)
                {

                    tb_question.Text = "";
                    tb_questionID.Text = "";
                    tb_categoryTag.Text = "";
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
                

            }
            catch (Exception Exception)
            {

                throw Exception;
            }
        }
    }
}