using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyTechSystem.Core;

namespace HappyTechSystem
{
    /// <summary>
    /// Created by Dan.
    /// UI form that allows the user to view emails from the database.
    /// </summary>
    public partial class ViewEmail : Form
    {
        EmailBank emailBank = EmailBank.getInst();
        public ViewEmail()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewEmail_Load(object sender, EventArgs e)
        {
            lb_email.DataSource = emailBank.getEmailList;
            lb_email.SelectedIndex = 0;
        }

        private void lb_email_SelectedIndexChanged(object sender, EventArgs e)
        {
            Email email = (Email) lb_email.SelectedItem;
            tb_emailID.Text = email.getID.ToString();
            tb_template.Text = emailBank.getTemplateList.Where(temp => temp.getID == email.getTemplateID).ToList().First().ToString();
            tb_address.Text = email.getAddress;
            tb_subject.Text = email.getSubject;
            tb_date.Text = email.getSentDate;
            tb_emailPreview.Text = email.getContent;
        }
    }
}
