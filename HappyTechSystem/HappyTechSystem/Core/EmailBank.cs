using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyTechSystem.DB;

namespace HappyTechSystem.Core
{
    class EmailBank
    {
        /// Created by Susan
        /// 25/11/2016
        /// Stores and manages emails and email templates

        private List<Email> emailRecords= new List<Email>(); //Stores all applicants email addresses
        private List<EmailTemplate> templates = new List<EmailTemplate>();
        private bool dbLoaded;

        private static EmailBank uniqueInst = null;
        public EmailBank()
        {
            RefreshDBConnection();
        }
        public static EmailBank getInst()
        {
            if (uniqueInst == null)
            {
                uniqueInst = new EmailBank();
            }
            return uniqueInst;
        }

        public void AddTemplate(EmailTemplate EB) 
        {
            templates.Add(EB);
        }

        public void RemoveTemplate(int m_id)
        {

        }

        public void SendEmail()
        {

        }

        public void RefreshDBConnection()
        {
            try
            {
                MetaLayer ml = MetaLayer.instance();
                templates = ml.getEmailTemplates();
                dbLoaded = true;
            }
            catch (Exception e)
            {
                dbLoaded = false;
                throw e;
            }
        }
    }
}
