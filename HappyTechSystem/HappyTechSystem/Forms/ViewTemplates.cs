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
    /// UI form that displays all email templates from the database.
    /// </summary>
    public partial class ViewTemplates : Form
    {
        //variable that acts as a toggle within the edit button
        private byte flag;
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
            if (flag == 0)
            {
                p_editToolbox.Enabled = true;
                lb_templates.Enabled = false;
                cb_type.Enabled = true;
                tb_templateName.ReadOnly = false;
                tb_subject.ReadOnly = false;
                tb_body.ReadOnly = false;
                flag++;
            }
            else
            {
                p_editToolbox.Enabled = false;
                lb_templates.Enabled = true;
                cb_type.Enabled = false;
                tb_templateName.ReadOnly = true;
                tb_subject.ReadOnly = true;
                tb_body.ReadOnly = true;
                flag--;
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
                int index = 0;
            }
        }
    }
}
