using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using HappyTechSystem.Core;

namespace HappyTechSystem
{
    /// <summary>
    /// Created by Dan.
    /// UI form that displays all email templates from the database.
    /// </summary>
    public partial class ViewTemplates : Form
    {
        //variable that acts as a toggle within the edit button
        private bool flag = true;
        private string str;
        private EmailBank emailBank = EmailBank.getInst();

        public ViewTemplates()
        {
            InitializeComponent();
            foreach (EmailTemplate emailTemplate in EmailBank.getInst().getTemplateList)
            {
                lb_templates.Items.Add(emailTemplate);
            }
        }

        /// <summary>
        /// Created by Dan.
        /// Enables form fields to allow for editing.
        /// A flag is used to toggle between the two states.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                p_editToolbox.Enabled = true;
                gb_tags.Enabled = true;
                lb_templates.Enabled = false;
                cb_type.Enabled = true;
                tb_templateName.ReadOnly = false;
                tb_subject.ReadOnly = false;
                tb_body.ReadOnly = false;
                flag = false;
            }
            else
            {
                p_editToolbox.Enabled = false;
                gb_tags.Enabled = false;
                lb_templates.Enabled = true;
                cb_type.Enabled = false;
                tb_templateName.ReadOnly = true;
                tb_subject.ReadOnly = true;
                tb_body.ReadOnly = true;
                flag = true;
            }
        }

        /// <summary>
        /// Created by Dan.
        /// button event handler to close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewTemplates_Load(object sender, EventArgs e)
        {
            p_editToolbox.Enabled = false;
            gb_tags.Enabled = false;

            try
            {
                lb_templates.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
        }

        private void lb_templates_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                EmailTemplate et = (EmailTemplate) lb_templates.SelectedItem;
                tb_templateID.Text = et.getID.ToString();
                tb_templateName.Text = et.getName;
                cb_type.Text = et.getType;
                tb_subject.Text = et.getSubject;
                tb_body.Text = et.getBody;
            }
            catch (Exception)
            {
                wipeAllFields();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //delete the selected template
            EmailTemplate et = (EmailTemplate) lb_templates.SelectedItem;
            int associatedEmail = 0;

            foreach (Email em in emailBank.getEmailList)
            {
                if (et.getID == em.getTemplateID)
                {
                    associatedEmail++;
                }
            }

            if (associatedEmail == 0)
            {
                DialogResult dialogResult = MessageBox.Show("You are about to delete this template permanently." +
                                                            "\n\nAre you sure you want to delete this template?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    //deletion of email
                    emailBank.RemoveTemplate(et.getID);
                    lb_templates.DataSource = emailBank.getTemplateList;

                    try
                    {
                        btn_edit.PerformClick();
                        lb_templates.SelectedIndex = 0;
                    }
                    catch (Exception)
                    {
                        tb_templateID.Text = "";
                        tb_templateName.Text = "";
                        tb_subject.Text = "";
                        tb_body.Text = "";
                    }
                    
                    MessageBox.Show("Template Successfully Deleted.", "Deletion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot delete this template due to one or more of the following reasons:"+
                    "\n\n(X) This template is still bound to an email/emails. There are " + associatedEmail +" associated emails using this template -  check to see which ones they " +
                                "are by checking the 'View Templates' menu.\n Removing these emails will allow you to remove this template.","Cannot Delete Template", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            EmailTemplate et = (EmailTemplate)lb_templates.SelectedItem;
            int associatedEmail = 0;

            foreach (Email em in emailBank.getEmailList)
            {
                if (et.getID == em.getTemplateID)
                {
                    associatedEmail++;
                }
            }

            if (associatedEmail == 0)
            {
                DialogResult dialogResult = MessageBox.Show("You are about to overwrite this template with the changes you have made." +
                                                            "\n\nAre you sure you want to overwrite this template?",
                                                            "Overwrite Template?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    TemplateCreator templateCreator = TemplateCreator.getInst();
                    templateCreator.CreateModifyTemplate(et.getID, cb_type.Text, tb_templateName.Text, tb_subject.Text, tb_body.Text, 1);
                    lb_templates.DataSource = emailBank.getTemplateList;

                    try
                    {
                        btn_edit.PerformClick();
                        lb_templates.SelectedIndex = 0;
                    }
                    catch (Exception)
                    {
                        tb_templateID.Text = "";
                        tb_templateName.Text = "";
                        tb_subject.Text = "";
                        tb_body.Text = "";
                    }

                    MessageBox.Show("The template '" + et.getName + "' was successfully modified.", "Edit Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("You cannot delete this template due to one or more of the following reasons:" +
                    "\n\n(X) This template is still bound to an email/emails. There are " + associatedEmail + " associated emails using this template -  check to see which ones they " +
                                "are by checking the 'View Templates' menu.\n Removing these emails will allow you to remove this template.", "Cannot Delete Template", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wipeAllFields()
        {
            tb_templateID.Text = "";
            tb_subject.Text = "";
            tb_templateName.Text = "";
            cb_type.Text = "";
            tb_body.Text = "";
        }

        private void SaveUnlocker(object sender, EventArgs e)
        {
            str = tb_body.Text;

            if (str.Contains("[IntervieweeName]"))
            {
                lbl_INFound.ForeColor = Color.Green;
                lbl_INFound.Text = "Found!";
            }
            else
            {
                lbl_INFound.ForeColor = Color.Red;
                lbl_INFound.Text = "Not Found!";
            }

            if (str.Contains("[JobRole]"))
            {
                lbl_JRFound.ForeColor = Color.Green;
                lbl_JRFound.Text = "Found!";
            }
            else
            {
                lbl_JRFound.ForeColor = Color.Red;
                lbl_JRFound.Text = "Not Found!";
            }

            if (str.Contains("[FeedbackArea]"))
            {
                lbl_FAFound.ForeColor = Color.Green;
                lbl_FAFound.Text = "Found!";
            }
            else
            {
                lbl_FAFound.ForeColor = Color.Red;
                lbl_FAFound.Text = "Not Found!";
            }
            if (str.Contains("[SenderName]"))
            {
                lbl_SNFound.ForeColor = Color.Green;
                lbl_SNFound.Text = "Found!";
            }
            else
            {
                lbl_SNFound.ForeColor = Color.Red;
                lbl_SNFound.Text = "Not Found!";
            }

            if (
                string.IsNullOrEmpty(cb_type.Text) ||
                string.IsNullOrEmpty(tb_templateName.Text) ||
                string.IsNullOrEmpty(tb_subject.Text) ||
                string.IsNullOrEmpty(tb_body.Text) ||
                lbl_INFound.Text != "Found!" ||
                lbl_JRFound.Text != "Found!" ||
                lbl_SNFound.Text != "Found!" ||
                lbl_FAFound.Text != "Found!"
                )

            {
                btn_save.Enabled = false;
            }
            else
            {
                btn_save.Enabled = true;
            }
        }
        private void btn_INadd_Click(object sender, EventArgs e)
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

        private void btn_JRadd_Click(object sender, EventArgs e)
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

        private void btn_FAadd_Click(object sender, EventArgs e)
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

        private void btn_SNadd_Click(object sender, EventArgs e)
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
