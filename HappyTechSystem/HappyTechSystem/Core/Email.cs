using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyTechSystem;

namespace HappyTechSystem.Core
{
    /// <summary>
    /// Created By Susan. 
    /// Creates the email type, with relevant fields that make up an email record.
    /// Features gets and its own ToString() override.
    /// </summary>
    public class Email
    {
        private string applicantEmail, content, subject;
        private string sentDate = "Not Yet Sent";
        private int emailID, templateID, interviewID;

        public string getAddress
        {
            get { return applicantEmail; }
            set { applicantEmail = value; } 
        }

        public string getContent
        {
            get { return content; }
            set { content = value; }
        }

        public string getSubject
        {
            get { return subject; }
            set { subject = value; }
        }

        public int getID
        {
            get { return emailID; }
            set { emailID = value; }
        }

        public int getTemplateID
        {
            get { return templateID; }
            set { templateID = value; }
        }
        public int getInterviewID
        {
            get { return interviewID; }
            set { interviewID = value; }
        }
        public string getSentDate
        {
            get { return sentDate; }
            set { sentDate = value; }
        }
        public override string ToString()
        {
            return "(" + emailID.ToString() + ") - [Interview # "+ interviewID.ToString()+"] - " + applicantEmail;
        }
    }
}
