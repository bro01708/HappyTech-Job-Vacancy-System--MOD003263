using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTechSystem
{
    public partial class ConductInterview : Form
    {
        public ConductInterview()
        {
            InitializeComponent();
        }

        //browse for the CV file and paste the file path to the relevant textbox (tb_cvPath)
        private void btn_browseCV_Click(object sender, EventArgs e)
        {
            int size;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (Exception)
                {
                    {
                        
                    }
                    throw;
                }
                tb_cvPath.Text = file;
            }
;
        }

        private void btn_beginInterview_Click(object sender, EventArgs e)
        {
            p_setup.Enabled = false;
            p_questions.Enabled = true;
        }

        private void btn_beginHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To begin the interivew process, you will need to first set-up some interviewee information.\n" +
                            "Make sure all fields are filled out correctly to proceed.", "Why is the 'Begin Interview' button greyed out?", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btn_interviewHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The interview process covers the questions set within the vacancy, beginning with Question 1.\n" +
                            "During the interview, pick a rank based on the quality of the interviewee's response.\n" +
                            "Move through the questions at your own pace, using the 'Previous' and 'Next' buttons.\n" +
                            "Add additional notes if need be, and click 'Complete Interview' when you are finished.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
