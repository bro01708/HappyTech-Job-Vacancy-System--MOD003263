using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public ViewTemplates()
        {
            InitializeComponent();
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
                tb_templateName.ReadOnly = false;
                tb_greeting.ReadOnly = false;
                tb_subject.ReadOnly = false;
                tb_body.ReadOnly = false;
                tb_signOff.ReadOnly = false;
                flag++;
            }
            else
            {
                p_editToolbox.Enabled = false;
                lb_templates.Enabled = true;
                tb_templateName.ReadOnly = true;
                tb_greeting.ReadOnly = true;
                tb_subject.ReadOnly = true;
                tb_body.ReadOnly = true;
                tb_signOff.ReadOnly = true;
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
    }
}
