using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyTechSystem.DB;

namespace HappyTechSystem.Core
{
    public class EmailBank
    {
        private MetaLayer ml = MetaLayer.instance();
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

        public int getHighestTemplateID()
        {
            try
            {
                int templateCount = templates.Count();

                if (templateCount == 0)
                {
                    return templateCount;
                }
                return templates[templateCount - 1].getID;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int getHighestEmailID()
        {
            try
            {
                int emailCount = emailRecords.Count();

                if (emailCount == 0)
                {
                    return emailCount;
                }
                return emailRecords[emailCount - 1].getID;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool getDBLoaded
        {
            get { return dbLoaded; }
        }

        public static EmailBank getInst()
        {
            if (uniqueInst == null)
            {
                uniqueInst = new EmailBank();
            }
            return uniqueInst;
        }

        public List<EmailTemplate> getTemplateList
        {
            get { return templates;}
        }

        public List<Email> getEmailList
        {
            get { return emailRecords; }
        }

        public void addTemplateToList(EmailTemplate m_et) 
        {
            templates.Add(m_et);
            ml.SaveTemplateToDB(m_et);
        }
        public void addEmailToList(Email e)
        {
            emailRecords.Add(e);
            ml.SaveEmailToDB(e);
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
                templates = ml.GetEmailTemplates();
                emailRecords = ml.GetEmails();
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
