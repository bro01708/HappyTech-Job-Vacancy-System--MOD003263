using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyTechSystem.DB;
using System.Net.Mail;
using System.Net;

namespace HappyTechSystem.Core
{
    public class EmailBank
    {
        private MetaLayer ml = MetaLayer.instance();

        /// Created by Susan
        /// 25/11/2016
        /// Stores and manages emails and email templates

        private List<Email> emailRecords = new List<Email>(); //Stores all applicants email addresses

        private List<EmailTemplate> templates = new List<EmailTemplate>();
        private bool dbLoaded;

        private static EmailBank uniqueInst;

        public EmailBank()
        {
            RefreshDBConnection();
        }

        public int getHighestTemplateID()
        {
            try
            {
                int templateCount = templates.Count;

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
                int emailCount = emailRecords.Count;

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
            get { return templates; }
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

        public void RemoveTemplate(int m_templateID)
        {
            foreach (EmailTemplate et in templates)
            {
                if (et.getID == m_templateID)
                {
                    templates.Remove(et);
                    ml.RemoveTemplateFromDB(m_templateID);
                    break;
                }
            }
        }

        public void RemoveEmail(int m_emailID)
        {
            try
            {
                foreach (Email e in emailRecords)
                {
                    if (e.getID == m_emailID)
                    {
                        emailRecords.Remove(e);
                        ml.RemoveEmailFromDB(m_emailID);
                    }
                }
            }
            catch (Exception)
            {

            }


        }

        public void UpdateTemplateList(EmailTemplate m_et)
        {
            ml.UpdateTemplateInDB(m_et);
            RefreshDBConnection();
        }

        public void UpdateEmailList(Email m_e)
        {
            ml.UpdateEmailInDB(m_e);
            RefreshDBConnection();
        }

        /// <summary>
        /// Created by Dan. 
        /// Uses SMTP to send emails from a certain mock email address to applicants.
        /// </summary>
        /// <param name="m_em"></param>
        public void SendEmail(Email m_em)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            MailMessage mail = new MailMessage("happytech1337@gmail.com", m_em.getAddress);
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("happytech1337@gmail.com", "happytech");
            client.EnableSsl = true;
            mail.Subject = m_em.getSubject;
            mail.Body = m_em.getContent;

            try
            {
                client.Send(mail);
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Created By Dan. 
        /// Fetches the email templates and emails from the database, assigning them to the local lists.
        /// </summary>
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
