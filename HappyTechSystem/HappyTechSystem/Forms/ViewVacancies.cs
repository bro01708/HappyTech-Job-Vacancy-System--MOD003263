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
        private byte flag;
        public ViewVacancies()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                p_editToolbox.Enabled = true;
                tb_vacancyName.ReadOnly = false;
                nud_acceptance.ReadOnly = false;
                nud_slots.ReadOnly = false;
                btn_moveQuestion.Enabled = true;
                btn_removeQuestion.Enabled = true;
                flag++;

            }
            else
            {
                p_editToolbox.Enabled = false;
                tb_vacancyName.ReadOnly = true;
                nud_acceptance.ReadOnly = true;
                nud_slots.ReadOnly = true;
                btn_moveQuestion.Enabled = false;
                btn_removeQuestion.Enabled = false;
                flag--;
            }

        }
    }
}
