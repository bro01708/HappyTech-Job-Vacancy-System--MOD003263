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
    public partial class QuestionCreatorForm : Form
    {
        private int pID;
        private Question q;
        private questionBank qb = questionBank.getInst();

        public QuestionCreatorForm(int m_ID)
        {
            InitializeComponent();
            pID = m_ID;
            tb_ID.Text = m_ID.ToString();
        }

        private void btn_CreateQuestion_Click(object sender, EventArgs e)
        {
            q = new Question(pID, tb_Tag.Text, tb_QText.Text);
            qb.addToList(q);
            MessageBox.Show("Question Added! Closing...");
            this.Close();
        }
    }
}
