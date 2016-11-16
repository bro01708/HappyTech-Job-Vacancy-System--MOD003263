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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //new form variables created, followed by event handlers when a menu strip item is clicked on
        QuestionCreation questionCreation;
        ViewQuestionBank viewQuestionBank;
        private void createAQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (questionCreation == null)
                questionCreation = new QuestionCreation();
                questionCreation.MdiParent = this;
                questionCreation.Show();
        }

        private void viewQuestionBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewQuestionBank = new ViewQuestionBank();
            viewQuestionBank.MdiParent = this;
            viewQuestionBank.Show();
        }

        //allows the splash screen labels to hide when a form is opened
        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                lbl_welcome.SendToBack();
                lbl_nav.SendToBack();
                lbl_dev.SendToBack();
                pb_logo.SendToBack();
            }
            else
            {
                lbl_welcome.BringToFront();
                lbl_nav.BringToFront();
                lbl_dev.BringToFront();
                pb_logo.BringToFront();
            }
        }
    }
}
