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
        public QuestionCreatorForm(int m_ID)
        {
            InitializeComponent();
            tb_ID.Text = m_ID.ToString();
        }


    }
}
