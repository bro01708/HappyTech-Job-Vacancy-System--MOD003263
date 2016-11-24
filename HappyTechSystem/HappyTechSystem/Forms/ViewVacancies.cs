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
    public partial class ViewVacancies : Form
    {
        public ViewVacancies()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            p_editToolbox.Enabled = true;
            btn_moveQuestion.Enabled = true;
            btn_removeQuestion.Enabled = true;
        }
    }
}
