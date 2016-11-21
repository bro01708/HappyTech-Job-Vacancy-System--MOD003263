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
    public partial class ViewQuestionBank : Form
    {
        public ViewQuestionBank()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //alter tables within the database
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //allow all fields bar questionID to be edited.
        }
    }
}
