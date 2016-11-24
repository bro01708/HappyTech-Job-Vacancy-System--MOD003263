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
    /// UI Form to support question creation, plugging into the database as necessary.
    /// </summary>
    public partial class CreateQuestion : Form
    {
        public CreateQuestion()
        {
            InitializeComponent();
        }

        private void btn_qIDHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The question ID is automatically incremented, so there's no need to manually enter an ID!");
        }

        private void CreateQuestion_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btn_deleteCategory_Click(object sender, EventArgs e)
        {
            //if selection is "base", dont allow deletion!
        }

        private void btn_manageCategories_Click(object sender, EventArgs e)
        {
            gb_question.Enabled = false;
            gb_category.Enabled = true;
        }

        private void btn_categoryDone_Click(object sender, EventArgs e)
        {
            gb_category.Enabled = false;
            gb_question.Enabled = true;
        }
    }
}
