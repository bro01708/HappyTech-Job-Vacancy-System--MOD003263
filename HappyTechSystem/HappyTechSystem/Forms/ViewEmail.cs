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
    public partial class ViewEmail : Form
    {
        private byte flag;
        public ViewEmail()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                p_editToolbox.Enabled = true;
                tb_emailPreview.ReadOnly = false;
                flag++;
            }
            else
            {
                p_editToolbox.Enabled = false;
                tb_emailPreview.ReadOnly = true;
                flag--;
            }
        }
    }
}
