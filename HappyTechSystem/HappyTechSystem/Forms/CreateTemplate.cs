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
    public partial class CreateTemplate : Form
    {
        public CreateTemplate()
        {
            InitializeComponent();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To create a new template, use the fields provided.\n" + 
                            "The buttons on the right side help plug in the necesscary information into the template.\n" + 
                            "Bear in mind that all fields need not be empty for the 'Create Template' button to activate.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_feedbackHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button inserts the feedback area for your email template.\n" +
                            "This is typically where all of the question feedback will be placed.", "What's a Feedback Area?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
