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
        
        //new form variables are created, followed by event handlers when a menu strip item is clicked on, to allow a form to display within the main mdi form
        #region Form Variables
        //question forms
        private static CreateQuestion createQuestion;
        private ModifyQuestion modifyQuestion;
        private ViewQuestionBank viewQuestionBank;
        //interview forms
        ConductInterview conductInterview;
        ViewInterview viewInterview;
        //template forms
        CreateTemplate createTemplate;
        ModifyTemplate modifyTemplate;
        ViewTemplates viewTemplates;
        //vacancy forms
        CreateVacancy createVacancy;
        ModifyVacancy modifyVacancy;
        ViewVacancies viewVacancies;
        //email forms
        ModifyEmail modifyEmail;
        ViewEmail viewEmail;

        #endregion
        //allows the splash screen labels to hide when a form is opened, showing again when the forms closed
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

        #region Creation Menu Items
        private void newQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newEmailTempleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (createTemplate == null)
            {
                createTemplate = new CreateTemplate();
                createTemplate.MdiParent = this;
                createTemplate.Show();
            }
        }

        private void newVacancyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (createVacancy == null)
            {
                createVacancy = new CreateVacancy();
                createVacancy.MdiParent = this;
                createVacancy.Show();
            }
        }

        private void conductInterviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conductInterview == null)
            {

                conductInterview = new ConductInterview();
                //formCheck(conductInterview);
                conductInterview.MdiParent = this;
                conductInterview.Show();
            }
        }

        #endregion

        #region Modify Menu Items
        private void modifyQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifyQuestion == null)
            {
                modifyQuestion = new ModifyQuestion();
                modifyQuestion.MdiParent = this;
                modifyQuestion.Show();
            }
        }

        private void modifyEmailTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifyTemplate == null)
            {
                modifyTemplate = new ModifyTemplate();
                modifyTemplate.MdiParent = this;
                modifyTemplate.Show();
            }
        }

        private void modifyVacancyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifyVacancy == null)
            {
                modifyVacancy = new ModifyVacancy();
                modifyVacancy.MdiParent = this;
                modifyVacancy.Show();
            }
        }

        private void modifyEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifyEmail == null)
            {
                modifyEmail = new ModifyEmail();
                modifyEmail.MdiParent = this;
                modifyEmail.Show();
            }
        }
        #endregion

        #region View Menu Items
        private void viewQuestionBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewQuestionBank == null)
            {
                viewQuestionBank = new ViewQuestionBank();
                viewQuestionBank.MdiParent = this;
                viewQuestionBank.Show();
            }
        }

        private void viewEmailTemplatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewTemplates == null)
            {
                viewTemplates = new ViewTemplates();
                viewTemplates.MdiParent = this;
                viewTemplates.Show();
            }
        }

        private void viewVacanciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewVacancies == null)
            {
                viewVacancies = new ViewVacancies();
                viewVacancies.MdiParent = this;
                viewVacancies.Show();
            }
        }

        private void viewInterviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewInterview == null)
            {
                viewInterview = new ViewInterview();
                viewInterview.MdiParent = this;
                viewInterview.Show();
            }
        }
        private void viewEmailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewEmail == null)
            {
                viewEmail = new ViewEmail();
                viewEmail.MdiParent = this;
                viewEmail.Show();
            }
        }
        #endregion

        //form checker
        private void formCheck(Type f)
        {
            string st = f.ToString();
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CreateQuestion))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new CreateQuestion();
            newForm.MdiParent = this;
            newForm.Show();
        }
    }
}
