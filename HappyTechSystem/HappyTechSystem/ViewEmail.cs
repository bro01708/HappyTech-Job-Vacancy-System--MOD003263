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
        public ViewEmail()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            p_editToolbox.Enabled = true;
        }
    }
}
