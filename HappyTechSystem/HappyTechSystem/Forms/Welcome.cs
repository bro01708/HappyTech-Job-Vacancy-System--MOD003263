using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTechSystem.Forms
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private string name;

        public string getName
        {
            get { return name; }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            MdiParent.MainMenuStrip.Enabled = true;
            name = tb_name.Text;
            MdiParent.Text = "Application Manager - " + name;
            this.Close();
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            UnlockButton();
        }

        private void UnlockButton()
        {
            if (tb_name.Text == "")
            {
                btn_start.Enabled = false;
            }
            else
            {
                btn_start.Enabled = true;
            }
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            UnlockButton();
        }
    }
}
