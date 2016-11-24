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
    public partial class CreateVacancy : Form
    {
        public CreateVacancy()
        {
            InitializeComponent();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You will need at least five questions to create a vacancy.\nChoose from the question bank and click 'Create Vacancy' when you're done");

        }
    }
}
