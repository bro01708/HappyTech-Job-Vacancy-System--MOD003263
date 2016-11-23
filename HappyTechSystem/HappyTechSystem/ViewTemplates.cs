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
    public partial class ViewTemplates : Form
    {
        private byte flag = 0;
        public ViewTemplates()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                p_editToolbox.Enabled = true;
                lb_templates.Enabled = false;
                tb_greeting.ReadOnly = false;
                tb_subject.ReadOnly = false;
                tb_body.ReadOnly = false;
                tb_signOff.ReadOnly = false;
                flag++;
            }
            else
            {
                p_editToolbox.Enabled = false;
                lb_templates.Enabled = true;
                tb_greeting.ReadOnly = true;
                tb_subject.ReadOnly = true;
                tb_body.ReadOnly = true;
                tb_signOff.ReadOnly = true;
                flag--;
            }
        }
    }
}
