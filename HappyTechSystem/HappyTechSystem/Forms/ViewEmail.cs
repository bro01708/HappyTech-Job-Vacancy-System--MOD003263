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
    /// UI form that allows the user to view emails from the database.
    /// </summary>
    public partial class ViewEmail : Form
    {
        //variable to enable toggling. (should be a boolean?)
        private byte flag;
        public ViewEmail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Created by Dan.
        /// Button event handler that toggles the active form controls.
        /// A flag is used to act as a button toggle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
