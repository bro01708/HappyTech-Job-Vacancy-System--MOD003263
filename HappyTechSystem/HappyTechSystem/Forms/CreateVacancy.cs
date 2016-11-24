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
    /// <summary>
    /// Created by Dan.
    /// UI form to help users create vacancies, to be used by interviews.
    /// </summary>
    public partial class CreateVacancy : Form
    {
        public CreateVacancy()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Created by Dan.
        /// General help regarding form functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You will need at least five questions to create a vacancy.\n" +
                            "Choose from the question bank and click 'Create Vacancy' when you're done.\n" +
                            "Remember that all fields should be filled out before a Vacancy can be made.", "Why is the 'Create Vacancy' button greyed out?", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
