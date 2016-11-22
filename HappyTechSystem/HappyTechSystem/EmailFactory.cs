using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem
{
    class EmailFactory
    {
        private List<Email> emailRecords= new List<Email>(); //Stores all applicants email addresses
        private List<EmailTemplate> templates = new List<EmailTemplate>();
        private bool dbLoaded;

        private static EmailFactory uniqueInst = null;
        public EmailFactory()
        {
            RefreshDBConnection();
        }
        public static EmailFactory getInst()
        {
            if (uniqueInst == null)
            {
                uniqueInst = new EmailFactory();
            }
            return uniqueInst;
        }

        public void AddTemplate() 
        {

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
