using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

        /// <summary>
        /// Created by Dan
        /// allows the splash screen labels to hide when a form is opened, showing again when the forms closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                p_splash.SendToBack();
                p_databaseStatus.SendToBack();
            }
            else
            {
                p_splash.BringToFront();
                p_databaseStatus.BringToFront();
            }
        }

        #region Creation Menu Items

        private void newQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateQuestion createQuestion = new CreateQuestion();
            formCheck(createQuestion);
        }

        private void newEmailTempleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTemplate createTemplate = new CreateTemplate();
            formCheck(createTemplate);
        }

        private void newVacancyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateVacancy createVacancy = new CreateVacancy();
            formCheck(createVacancy);
        }

        private void conductInterviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConductInterview conductInterview = new ConductInterview();
            formCheck(conductInterview);
        }

        #endregion

        #region Modify and View Menu Items

        private void modifyViewQuestionBankToolStripMenuItemClick(object sender, EventArgs e)
        {
            ViewQuestionBank viewQuestionBank = new ViewQuestionBank();
            formCheck(viewQuestionBank);
        }

        private void modifyViewEmailTemplatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTemplates viewTemplates = new ViewTemplates();
            formCheck(viewTemplates);
        }

        private void modifyViewVacanciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewVacancies viewVacancies = new ViewVacancies();
            formCheck(viewVacancies);
        }

        private void modifyViewInterviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewInterview viewInterview = new ViewInterview();
            formCheck(viewInterview);
        }

        private void modifyViewEmailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEmail viewEmail = new ViewEmail();
            formCheck(viewEmail);
        }

        #endregion

        /// <summary>
        /// Created By Peter.
        /// This Method checks to see if a form already has an instance active. 
        /// It accepts a form parameter and will create the form if it doesnt exist.
        /// </summary>
        /// <param name="f"></param>
        private void formCheck(Form f)
        {

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == f.GetType())
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = f;
            newForm.MdiParent = this;
            newForm.Show();
        }
        /// <summary>
        /// Created by Dan
        /// On MDI Parent Load, allow the background color to be editable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            MdiClient chld;

            foreach (Control ctrl in this.Controls)
            {
                try
                {
                    chld = (MdiClient)ctrl;

                    chld.BackColor = this.BackColor;
                }
                catch (InvalidCastException exe)
                {

                }
            }
        }
    }
}
