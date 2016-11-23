using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyTechSystem.DB;
using HappyTechSystem.Core;

namespace HappyTechSystem
{
    public partial class DBTest : Form
    {
        List<Question> m_customers;
        BindingSource m_bs;

        public DBTest()
        {
            InitializeComponent();
            m_bs = new BindingSource();
            m_bs.DataSource = m_customers;
            comboBox1.DataSource = m_bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetaLayer ml = MetaLayer.instance();
            m_customers = ml.getQuestions();
            m_bs.DataSource = m_customers;
            m_bs.ResetBindings(false);
        }
    }
}
