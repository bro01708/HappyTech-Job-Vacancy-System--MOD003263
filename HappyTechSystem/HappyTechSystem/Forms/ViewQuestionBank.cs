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
        private byte flag;

        public ViewQuestionBank()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //alter tables within the database
        }

        /// <summary>
        /// Created by Dan.
        /// This button event handler enables most of the read-only fields, allowing them to be editing temporarily.
        /// A flag is used to act as a button toggle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_Click(object sender, EventArgs e)
        { 

            if (flag == 0)
            {
                p_editToolbox.Enabled = true;
                lb_Q.Enabled = false;
                btn_close.Enabled = false;
                tb_categoryTag.ReadOnly = false;
                tb_question.ReadOnly = false;
                tb_feedback1.ReadOnly = false;
                tb_feedback2.ReadOnly = false;
                tb_feedback3.ReadOnly = false;
                tb_feedback4.ReadOnly = false;
                tb_feedback5.ReadOnly = false;
                tb_response1.ReadOnly = false;
                tb_response2.ReadOnly = false;
                tb_response3.ReadOnly = false;
                tb_response4.ReadOnly = false;
                tb_response5.ReadOnly = false;
                flag++;
            }
            else
            {
                p_editToolbox.Enabled = false;
                lb_Q.Enabled = true;
                btn_close.Enabled = true;
                tb_categoryTag.ReadOnly = true;
                tb_question.ReadOnly = true;
                tb_feedback1.ReadOnly = true;
                tb_feedback2.ReadOnly = true;
                tb_feedback3.ReadOnly = true;
                tb_feedback4.ReadOnly = true;
                tb_feedback5.ReadOnly = true;
                tb_response1.ReadOnly = true;
                tb_response2.ReadOnly = true;
                tb_response3.ReadOnly = true;
                tb_response4.ReadOnly = true;
                tb_response5.ReadOnly = true;
                flag--;
            }
        }

        private void ViewQuestionBank_Load(object sender, EventArgs e)
        {
            //disables the edit tool box on form load
            p_editToolbox.Enabled = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}