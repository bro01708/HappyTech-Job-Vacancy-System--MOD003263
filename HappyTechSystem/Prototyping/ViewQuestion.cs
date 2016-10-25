using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototyping
{
    public partial class ViewQuestion : Form
    {
        private questionBank qb = questionBank.getInst();
        public ViewQuestion()
        {
            InitializeComponent();

            foreach (Question q in qb.getQ)
            {
                lb_Q.Items.Add(q);
            }
        }
    }
}
