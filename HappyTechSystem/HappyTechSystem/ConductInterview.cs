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
    }
}
