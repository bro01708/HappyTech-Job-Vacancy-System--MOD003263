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
            Question Question = (Question)lb_Q.SelectedItem;
            tb_QText.Text = Question.getText();
            tb_ID.Text = Question.getID().ToString();
            
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
