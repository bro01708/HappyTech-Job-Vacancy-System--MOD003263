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
    /// UI form to help users create vacancies, to be used by interviews.
    /// </summary>
    public partial class CreateVacancy : Form
    {
        VacancyBank vacancyBank = VacancyBank.getInst();
        VacancyCreator vacancyCreator = VacancyCreator.getInst();
        QuestionBank questionBank = QuestionBank.getInst();

        public CreateVacancy()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Created by Dan.
        /// General help regarding form functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You will need at least five questions to create a vacancy.\n" +
                            "Choose from the question bank and click 'Create Vacancy' when you're done.\n" +
                            "Remember that all fields should be filled out before a Vacancy can be made.", "Why is the 'Create Vacancy' button greyed out?", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CreateVacancy_Load(object sender, EventArgs e)
        {
            int nextID = vacancyBank.getHighestVacancyID() + 1 ;
            tb_VacancyID.Text = nextID.ToString();
            lb_questionBank.DataSource = questionBank.getQuestionList;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (lb_questionsToBeUsed.Items.Contains(lb_questionBank.SelectedItem))
            {
                MessageBox.Show("You cannot add duplicate questions to the 'Questions To Be Used' List.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lb_questionsToBeUsed.Items.Add(lb_questionBank.SelectedItem);
            }
            CreateButtonUnlocker();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            lb_questionsToBeUsed.Items.Remove(lb_questionsToBeUsed.SelectedItem);
            CreateButtonUnlocker();
        }

        private void CreateButtonUnlocker()
        {
            if (lb_questionsToBeUsed.Items.Count >= 5 && tb_vacancyName != null && nud_interviewSlots.Value >= 1 && tb_role != null)
            {
                btn_create.Enabled = true;
            }
            else
            {
                btn_create.Enabled = false;
            }
        }

        private void tb_vacancyName_TextChanged(object sender, EventArgs e)
        {
            CreateButtonUnlocker();
        }

        private void nud_interviewSlots_ValueChanged(object sender, EventArgs e)
        {
            CreateButtonUnlocker();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            List<int> questionIDs = new List<int>();
            foreach (Question q in lb_questionsToBeUsed.Items)
            {
                questionIDs.Add(q.GetID);
            }
            vacancyCreator.CreateModifyVacancy(Convert.ToInt32(tb_VacancyID.Text), tb_vacancyName.Text, tb_role.Text, Convert.ToInt32(nud_acceptanceScore.Value), Convert.ToInt32(nud_interviewSlots.Value), questionIDs, 0);
            MessageBox.Show("Vacancy Created Successfully!\n\nTo view your vacancy, check the 'View Vacancies' menu!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
