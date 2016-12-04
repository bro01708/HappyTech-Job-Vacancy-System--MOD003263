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
    /// UI form that displays all vacancies from the database.
    /// </summary>
    public partial class ViewVacancies : Form
    {
        private VacancyBank vacancyBank = VacancyBank.getInst();
        private QuestionBank questionBank = QuestionBank.getInst();
        //variable that acts as a toggle. used by the edit button event handler
        private bool flag = true;

        public ViewVacancies()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Created by Dan.
        /// Enables fields on the form for edits to take place.
        /// A flag is in place to toggle the enabled and disabled states.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                p_editToolbox.Enabled = true;
                lb_vacancy.Enabled = false;
                tb_vacancyName.ReadOnly = false;
                tb_role.Enabled = false;
                nud_acceptance.ReadOnly = false;
                nud_slots.ReadOnly = false;
                btn_moveQuestion.Enabled = true;
                flag = false;

            }
            else
            {
                p_editToolbox.Enabled = false;
                lb_vacancy.Enabled = true;
                tb_vacancyName.ReadOnly = true;
                tb_role.Enabled = true;
                nud_acceptance.ReadOnly = true;
                nud_slots.ReadOnly = true;
                btn_moveQuestion.Enabled = false;
                btn_removeQuestion.Enabled = false;
                flag = true;
            }

        }

        private void lb_vacancy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_interviews.Items.Clear();
            lb_questionsUsed.Items.Clear();

            try
            {
                Vacancy v = (Vacancy) lb_vacancy.SelectedItem;
                tb_vacancyID.Text = v.GetID.ToString();
                tb_vacancyName.Text = v.VacancyName;
                tb_role.Text = v.Role;
                nud_acceptance.Value = v.MinumumScore;
                nud_slots.Value = v.PositionsAvailable;

                int index = 0;
                int count = v.getQuestionsToBeUsed.Count;

                //foreach (Question q in questionBank.getQuestionList)
                //{
                //    lb_questionBank.Items.Add(q.ToString());
                //}

                do
                {
                    foreach (Question q in questionBank.getQuestionList)
                    {
                        if (index == count)
                        {
                            break;
                        }

                        if (q.GetID == v.getQuestionsToBeUsed[index])
                        {
                            lb_questionsUsed.Items.Add((Question) q);
                            index++;
                        }
                    }
                } while (index != count);

                foreach (Interview I in vacancyBank.getInterviewList)
                {
                    if (I.getUsedVacancyID == v.GetID)
                    {
                        lb_interviews.Items.Add(I);
                    }
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        private void ViewVacancies_Load(object sender, EventArgs e)
        {
            p_editToolbox.Enabled = false;
            lb_vacancy.DataSource = vacancyBank.getVacancyList;
            lb_questionBank.DataSource = questionBank.getQuestionList;
            try
            {
                lb_vacancy.SelectedIndex = 0;
            }
            catch (Exception)
            {
                wipeAllFields();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewVacancies_FormClosing(object sender, FormClosingEventArgs e)
        {
            lb_interviews.Items.Clear();
            lb_questionsUsed.Items.Clear();
        }

        /// <summary>
        /// Created By Dan. 
        /// Removes the vacancy from the database and any local lists.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            Vacancy v = (Vacancy) lb_vacancy.SelectedItem;
            int associatedInterviews = 0;

            foreach (Interview i in vacancyBank.getInterviewList)
            {
                int vacancyID = i.getUsedVacancyID;
                if (i.getUsedVacancyID == v.GetID)
                {
                    associatedInterviews++;
                }
            }

            if (associatedInterviews == 0)
            {
                DialogResult dialogResult = MessageBox.Show("You are about to delete this vacancy permanently." +
                                                            "\n\nAre you sure you want to delete this vacancy?",
                    "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    //deletion of vacancy record
                    vacancyBank.RemoveVacancyFromList(v.GetID);
                    lb_vacancy.DataSource = vacancyBank.getVacancyList;


                    try
                    {
                        btn_edit.PerformClick();
                        lb_vacancy.SelectedIndex = 0;
                    }
                    catch (Exception)
                    {
                        wipeAllFields();
                    }

                    MessageBox.Show("The vacancy " + v.VacancyName + " was successfully deleted.", "Deletion Complete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot delete this vacancy due to one of more of the following reasons:" +
                                "\n\n(X) There are still interviews pending for email generation that are tied to this vacancy - generate emails for those interviews " +
                                "or remove them.", "Cannot Delete Vacancy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_moveQuestion_Click(object sender, EventArgs e)
        {
            removeCheck();

            if (lb_questionsUsed.Items.Contains(lb_questionBank.SelectedItem))
            {
                MessageBox.Show("You cannot add duplicate questions to the 'Questions To Be Used' List.",
                    "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lb_questionsUsed.Items.Add((Question) lb_questionBank.SelectedItem);
            }
        }

        private void btn_removeQuestion_Click(object sender, EventArgs e)
        {
            lb_questionsUsed.Items.Remove(lb_questionsUsed.SelectedItem);
        }

        private void removeCheck()
        {
            if (p_editToolbox.Enabled)
            {
                if (lb_questionsUsed.Items.Count == 5)
                {
                    btn_removeQuestion.Enabled = false;
                }
                else
                {
                    btn_removeQuestion.Enabled = true;
                }
            }
            else
            {
                btn_removeQuestion.Enabled = false;
            }
        }

        private void lb_questionBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeCheck();
        }

        private void lb_questionsUsed_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeCheck();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Vacancy v = (Vacancy) lb_vacancy.SelectedItem;
            int associatedInterviews = 0;

            foreach (Interview i in vacancyBank.getInterviewList)
            {
                int vacancyID = i.getUsedVacancyID;
                if (i.getUsedVacancyID == v.GetID)
                {
                    associatedInterviews++;
                }
            }

            if (associatedInterviews == 0)
            {
                DialogResult dialogResult = MessageBox.Show("You are about to overwrite this vacancy.\n\nAre you sure?",
                    "Overwrite Vacancy?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    List<int> questionIDs = new List<int>();
                    foreach (Question q in lb_questionsUsed.Items)
                    {
                        questionIDs.Add(q.GetID);
                    }

                    VacancyCreator vacancyCreator = VacancyCreator.getInst();
                    vacancyCreator.CreateModifyVacancy(v.GetID, tb_vacancyName.Text, tb_role.Text,
                        Convert.ToInt32(nud_acceptance.Value), Convert.ToInt32(nud_slots.Value), questionIDs, 1);
                    lb_vacancy.DataSource = vacancyBank.getVacancyList;

                    try
                    {
                        btn_edit.PerformClick();
                        lb_vacancy.SelectedIndex = 0;
                    }
                    catch (Exception)
                    {
                        wipeAllFields();
                    }

                    MessageBox.Show("The vacancy '" + v.VacancyName + "' was successfully modified.", "Edit Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You cannot edit this vacancy due to one of more of the following reasons:" +
                "\n\n(X) There are still interviews pending for email generation that are tied to this vacancy.", "Cannot Modify Vacancy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wipeAllFields()
        {
            tb_vacancyID.Text = "";
            tb_vacancyName.Text = "";
            tb_role.Text = "";
            nud_acceptance.Text = "";
            nud_slots.Text = "";
        }
    }
}
