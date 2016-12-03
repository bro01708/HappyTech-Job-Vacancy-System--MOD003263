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
            name = cb_name.Text;
            MdiParent.Text = "Application Manager - " + name;
            this.Close();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            cb_name.SelectedIndex = 0;
        }
    }
}
