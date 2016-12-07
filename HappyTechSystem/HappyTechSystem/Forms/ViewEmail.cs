using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyTechSystem.Core;


namespace HappyTechSystem
{
    /// <summary>
    /// Created by Dan.
    /// UI form that allows the user to view emails from the database.
    /// </summary>
    public partial class ViewEmail : Form
    {
        EmailBank emailBank = EmailBank.getInst();
        EmailCreator emailCreator = EmailCreator.getInst();
        private bool flag = true;

        public ViewEmail()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewEmail_Load(object sender, EventArgs e)
        {
            tb_emailPreview.TabStop = false;
            lb_email.DataSource = emailBank.getEmailList;
            gb_sendEmails.Enabled = false;
            p_editToolbox.Enabled = false;

            try
            {
                lb_email.SelectedIndex = 0;
            }
            catch (Exception)
            {
                wipeAllFields();
            }

        }

        private void lb_email_SelectedIndexChanged(object sender, EventArgs e)
        {
            Email email = (Email) lb_email.SelectedItem;
            tb_emailID.Text = email.getID.ToString();
            tb_template.Text =
                emailBank.getTemplateList.Where(temp => temp.getID == email.getTemplateID).ToList().First().ToString();
            tb_address.Text = email.getAddress;
            tb_subject.Text = email.getSubject;
            tb_date.Text = email.getSentDate;
            tb_emailPreview.Text = email.getContent;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                p_editToolbox.Enabled = true;
                lb_email.Enabled = false;
                tb_address.ReadOnly = false;
                tb_subject.ReadOnly = false;
                tb_emailPreview.ReadOnly = false;
                flag = false;
            }
            else
            {
                p_editToolbox.Enabled = false;
                lb_email.Enabled = true;
                tb_address.ReadOnly = true;
                tb_subject.ReadOnly = true;
                tb_emailPreview.ReadOnly = true;
                flag = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Email em = (Email) lb_email.SelectedItem;
            DialogResult dialogResult =
                MessageBox.Show("You are about to modify this email with the changes you have made." +
                                "\n\nAre you sure you want to save changes to this email?",
                    "Modify Email?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                emailCreator.ModifyEmail(em.getID, tb_address.Text, tb_subject.Text, tb_emailPreview.Text);
                lb_email.DataSource = emailBank.getEmailList;

                try
                {
                    btn_edit.PerformClick();
                    lb_email.SelectedIndex = 0;
                }
                catch (Exception)
                {
                    tb_emailID.Text = "";
                }

                MessageBox.Show("The email was successfully modified.", "Edit Complete", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Created by Dan. 
        /// Delete the selected email from the system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            Email em = (Email) lb_email.SelectedItem;
            DialogResult dialogResult =
                MessageBox.Show("You are about to delete this email from the system permanently." +
                                "\n\nAre you sure you want to delete this email?",
                                "Delete Email?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //deletion of email
                emailBank.RemoveEmail(em.getID);
                lb_email.DataSource = emailBank.getEmailList;

                try
                {
                    btn_edit.PerformClick();
                    lb_email.SelectedIndex = 0;
                }
                catch (Exception)
                {
                    tb_emailID.Text = "";
                }

                MessageBox.Show("The email was successfully deleted.\n\n " +
                                "The form will now close to update the list - reopen this menu to see the changes.", "Deletion Complete", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void wipeAllFields()
        {
            tb_emailID.Text = "";
            tb_template.Text = "";
            tb_address.Text = "";
            tb_subject.Text = "";
            tb_date.Text = "";
            tb_emailPreview.Text = "";
        }

        private void btn_sendEmails_Click(object sender, EventArgs e)
        {
            gb_sendEmails.Enabled = true;

            foreach (Email em in emailBank.getEmailList)
            {
                if (em.getSentDate == "Not Yet Sent")
                {
                    clb_emails.Items.Add(em);
                }
            }

            lb_email.Enabled = false;
            tb_emailID.Enabled = false;
            tb_template.Enabled = false;
            tb_address.Enabled = false;
            tb_subject.Enabled = false;
            tb_date.Enabled = false;
            tb_emailPreview.Enabled = false;
            btn_edit.Enabled = false;
            btn_close.Enabled = false;
            btn_prepareSend.Enabled = false;
            btn_send.Enabled = false;
        }

        /// <summary>
        /// Created by Dan. 
        /// Uses SMTP to send emails from a certain mock email address to applicants.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_Click(object sender, EventArgs e)
        {
            if (clb_emails.CheckedItems.Count == 0)
            {
                MessageBox.Show("You haven't ticked any emails in the list above.\n" +
                                "Please select at least one email to send.", "No Selected Emails", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("You are about to send the selected emails off to their destination addresses, which is an irreversible action.\n\n" +
                                                        "Are you sure you wish to proceed?", "Send Selected Emails?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (Email em in clb_emails.CheckedItems)
                    {
                        try
                        {
                            emailBank.SendEmail(em);
                            emailCreator.AdjustEmailSentDate(em.getID, DateTime.Now.ToShortDateString());
                            MessageBox.Show(clb_emails.CheckedItems.Count.ToString() + " email(s) has/have been sent to their destination address(es).", "Email Sent!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (clb_emails.Items.Count == 0) { break; }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Some emails could not be sent due to one or more of following reasons:\n\n" +
                                            "(X) The applicant email addresses stated are not in the correct format or do not actually exist.", "Error Sending Emails", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        btn_back.PerformClick();

                    }
                }
            }
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            clb_emails.Items.Clear();
            gb_sendEmails.Enabled = false;
            lb_email.Enabled = true;
            tb_emailID.Enabled = true;
            tb_template.Enabled = true;
            tb_address.Enabled = true;
            tb_subject.Enabled = true;
            tb_date.Enabled = true;
            tb_emailPreview.Enabled = true;
            btn_edit.Enabled = true;
            btn_close.Enabled = true;
            btn_prepareSend.Enabled = true;
        }

        private void UnlockSend(object sender, EventArgs e)
        {
            if (clb_emails.CheckedItems.Count == 0)
            {
                btn_send.Enabled = false;
            }
            else
            {
                btn_send.Enabled = true;
            }
        }
    }
}
