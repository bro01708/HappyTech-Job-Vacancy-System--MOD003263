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
            lb_templates.SelectedIndex = 0;
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
                    lb_templates.DataSource = null;
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
                    "\n\n(X) This template is still bound to emails. There are " + associatedEmail +" associated emails using this template -  check to see which ones they " +
                                "are by checking the 'View Templates' menu.\n Removing these emails will allow you to remove this template.","Cannot Delete Template", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
