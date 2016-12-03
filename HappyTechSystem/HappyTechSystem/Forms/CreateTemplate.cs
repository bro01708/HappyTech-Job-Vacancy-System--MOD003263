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
    /// UI form to help the user create a new email template, for use with email creation.
    /// </summary>
    public partial class CreateTemplate : Form
    {
        private MetaLayer ml = MetaLayer.instance();
        private EmailBank emailBank = EmailBank.getInst();
        private TemplateCreator templateCreator = TemplateCreator.getInst();
        private string str;
        public CreateTemplate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Created by Dan.
        /// Helpful information regarding form functions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To create a new template, use the fields provided.\n" + 
                            "The buttons on the right side help plug in the necesscary information into the template.\n" + 
                            "Bear in mind that all fields need not be empty for the 'Create Template' button to activate.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Created by Dan.
        /// General help regarding the feedback area insert button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_feedbackHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button inserts the feedback area for your email template.\n" +
                            "This is where all of the question feedback will be placed.", "What's a Feedback Area?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CreateTemplateUnlocker(object sender, EventArgs e)
        {
            str = tb_body.Text;

            if (str.Contains("[IntervieweeName]"))
            {
                lbl_INStatus.ForeColor = Color.Green;
                lbl_INStatus.Text = "Found!";
            }
            else
            {
                lbl_INStatus.ForeColor = Color.Red;
                lbl_INStatus.Text = "Not Found!";
            }

            if (str.Contains("[JobRole]"))
            {
                lbl_JRStatus.ForeColor = Color.Green;
                lbl_JRStatus.Text = "Found!";
            }
            else
            {
                lbl_JRStatus.ForeColor = Color.Red;
                lbl_JRStatus.Text = "Not Found!";
            }

            if (str.Contains("[FeedbackArea]"))
            {
                lbl_FAStatus.ForeColor = Color.Green;
                lbl_FAStatus.Text = "Found!";
            }
            else
            {
                lbl_FAStatus.ForeColor = Color.Red;
                lbl_FAStatus.Text = "Not Found!";
            }
            if (str.Contains("[SenderName]"))
            {
                lbl_SNStatus.ForeColor = Color.Green;
                lbl_SNStatus.Text = "Found!";
            }
            else
            {
                lbl_SNStatus.ForeColor = Color.Red;
                lbl_SNStatus.Text = "Not Found!";
            }

            if (
                string.IsNullOrEmpty(cb_type.Text) ||
                string.IsNullOrEmpty(tb_name.Text) ||
                string.IsNullOrEmpty(tb_subject.Text) ||
                string.IsNullOrEmpty(tb_body.Text) ||
                lbl_INStatus.Text != "Found!" ||
                lbl_JRStatus.Text != "Found!" ||
                lbl_SNStatus.Text != "Found!" ||
                lbl_FAStatus.Text != "Found!"
                )

            {
                btn_create.Enabled = false;
            }
            else
            {
                btn_create.Enabled = true;
            }

        }

        private void CreateTemplate_Load(object sender, EventArgs e)
        {
            int nextID = emailBank.getHighestTemplateID() + 1;
            tb_templateID.Text = nextID.ToString();
            str = tb_body.Text;
        }

        //public static string getBetween(string strSource, string strStart, string strEnd)
        //{
        //    int start, end;
        //    if (strSource.Contains(strStart) && strSource.Contains(strEnd))
        //    {
        //        start = strSource.IndexOf(strStart, 0) + strStart.Length;
        //        end = strSource.IndexOf(strEnd, start);
        //        return strSource.Substring(start, end - start);
        //    }
        //    else
        //    {
        //        return "";
        //    }
        //}


        private void btn_addName_Click(object sender, EventArgs e)
        {
            if (str.Contains("[IntervieweeName]"))
            {
                MessageBox.Show("The Interviewee's Name is already inserted!\nTo find it, look for the [IntervieweeName] tag!");
            }
            else
            {
                tb_body.Text = tb_body.Text.Insert(tb_body.SelectionStart, "[IntervieweeName]");
            }

        }

        private void btn_addRole_Click(object sender, EventArgs e)
        {
            if (str.Contains("[JobRole]"))
            {
                MessageBox.Show("The Job Role is already inserted!\nTo find it, look for the [JobRole] tag!");
            }
            else
            {
                tb_body.Text = tb_body.Text.Insert(tb_body.SelectionStart, "[JobRole]");
            }
        }

        private void btn_addFeedback_Click(object sender, EventArgs e)
        {
            if (str.Contains("[FeedbackArea]"))
            {
                MessageBox.Show("The Feedback Area is already inserted!\nTo find it, look for the [FeedbackArea] tag!");
            }
            else
            {
                tb_body.Text = tb_body.Text.Insert(tb_body.SelectionStart, "[FeedbackArea]");
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            templateCreator.CreateTemplate(Convert.ToInt32(tb_templateID.Text), cb_type.Text, tb_name.Text, tb_subject.Text, tb_body.Text);
            MessageBox.Show("Email Template Created Successfully!\n\nTo view your template, check the 'View Templates' menu!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_addSenderName_Click(object sender, EventArgs e)
        {
            if (str.Contains("[SenderName]"))
            {
                MessageBox.Show("The Sender Name is already inserted!\nTo find it, look for the [SenderName] tag!");
            }
            else
            {
                tb_body.Text = tb_body.Text.Insert(tb_body.SelectionStart, "[SenderName]");
            }
        }
    }
}
