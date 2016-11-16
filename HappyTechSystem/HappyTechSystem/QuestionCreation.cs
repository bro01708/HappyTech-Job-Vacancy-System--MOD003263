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
    public partial class QuestionCreation : Form
    {
        public QuestionCreation()
        {
            InitializeComponent();
        }

        private void btn_qIDHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The question ID is automatically incremented, so there's no need to manually enter an ID!");
        }

        private void QuestionCreation_Load(object sender, EventArgs e)
        {

        }
    }
}
