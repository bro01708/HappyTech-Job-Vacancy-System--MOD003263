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
        private byte flag = 0;

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
                flag = 1;
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
                flag = 0;
            }
            //allow all fields bar questionID to be edited.
            
        }

        private void ViewQuestionBank_Load(object sender, EventArgs e)
        {
            p_editToolbox.Enabled = false;
        }
    }
}
