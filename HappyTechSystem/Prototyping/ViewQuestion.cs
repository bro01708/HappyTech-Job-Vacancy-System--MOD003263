using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototyping
{
    public partial class ViewQuestion : Form
    {
        private questionBank qb = questionBank.getInst();
        private int id;
        private string tag, text;

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lb_Q_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Question q = (Question)lb_Q.SelectedItem;
                tb_QText.Text = q.getText();
                tb_ID.Text = q.getID().ToString();
                tb_Criteria1.Text = q.GetCriteriaAndFeedback(0);
                tb_feedback1.Text = q.GetCriteriaAndFeedback(1);
                tb_Criteria2.Text = q.GetCriteriaAndFeedback(2);
                tb_feedback2.Text = q.GetCriteriaAndFeedback(3);
                tb_Criteria3.Text = q.GetCriteriaAndFeedback(4);
                tb_feedback3.Text = q.GetCriteriaAndFeedback(5);
                tb_Criteria4.Text = q.GetCriteriaAndFeedback(6);
                tb_feedback4.Text = q.GetCriteriaAndFeedback(7);
                tb_Criteria5.Text = q.GetCriteriaAndFeedback(8);
                tb_feedback5.Text = q.GetCriteriaAndFeedback(9);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please click an entry in the textbox" + " " + ex.ToString());
            }
        }

        public ViewQuestion()
        {
            InitializeComponent();

            foreach (Question q in qb.getQ)
            {
                id = q.getID();
                tag = q.getTag();
                text = q.getText();
                lb_Q.Items.Add(q);
            }
        }
    }
}
