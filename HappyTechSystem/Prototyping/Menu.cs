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
    public partial class Menu : Form
    {
        private questionBank qb = questionBank.getInst();

        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            qb.LoadForm();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            ViewQuestion vq = new ViewQuestion();
            vq.Show();
        }
    }
}
