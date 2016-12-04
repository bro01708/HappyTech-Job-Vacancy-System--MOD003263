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
    /// UI form that allows the user to view emails from the database.
    /// </summary>
    public partial class ViewEmail : Form
    {
        EmailBank emailBank = EmailBank.getInst();
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
                EmailCreator emailCreator = EmailCreator.getInst();
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

                MessageBox.Show("The email was successfully modified.", "Edit Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                MessageBox.Show("The email was successfully deleted.", "Deletion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
