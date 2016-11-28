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
            if (
                string.IsNullOrEmpty(tb_name.Text) ||
                string.IsNullOrEmpty(tb_subject.Text) ||
                string.IsNullOrEmpty(tb_body.Text)
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
        }

        private void btn_insertGreeting_Click(object sender, EventArgs e)
        {
            tb_body.Text = tb_body.Text.Insert(tb_body.SelectionStart, "[Greeting]");
            btn_insertGreeting.Enabled = false;
        }

        private void btn_addName_Click(object sender, EventArgs e)
        {
            tb_body.Text = tb_body.Text.Insert(tb_body.SelectionStart, "[Interviewee's Name]");
            btn_addName.Enabled = false;
        }

        private void btn_position_Click(object sender, EventArgs e)
        {
            tb_body.Text = tb_body.Text.Insert(tb_body.SelectionStart, "[Position]");
            btn_position.Enabled = false;
        }

        private void btn_feedback_Click(object sender, EventArgs e)
        {
            tb_body.Text = tb_body.Text.Insert(tb_body.SelectionStart, "[Feedback Area for All Questions]");
            btn_feedback.Enabled = false;
        }

        private void btn_insertSignOff_Click(object sender, EventArgs e)
        {
            tb_body.Text = tb_body.Text.Insert(tb_body.SelectionStart, "[Sign Off]");
            btn_insertSignOff.Enabled = false;
        }

        private void btn_removeGreeting_Click(object sender, EventArgs e)
        {
            //remove the [Greeting] line from the body of text
        }
    }
}
