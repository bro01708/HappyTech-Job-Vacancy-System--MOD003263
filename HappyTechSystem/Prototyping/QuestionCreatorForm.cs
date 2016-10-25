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
        private questionBank qb;
        private Question q;
        private List<Question> ql;

        public QuestionCreatorForm(int m_ID)
        {
            InitializeComponent();
            pID = m_ID;
            tb_ID.Text = m_ID.ToString();
        }

        private void btn_CreateQuestion_Click(object sender, EventArgs e)
        {
            ql = qb.Questions;
            q = new Question(pID, tb_Tag.Text, tb_QText.Text);
            ql.Add(q);
        }
    }
}
