using HappyTechSystem.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTechSystem.Core
{
    /// <summary>
    /// Created by Dan.
    /// Class to form an email based on fields passed to it.
    /// </summary>
    class EmailCreator
    {
        private VacancyBank vacancyBank = VacancyBank.getInst();
        private QuestionBank questionbank = QuestionBank.getInst();
        private EmailBank EB = EmailBank.getInst();

        private static EmailCreator uniqueInst;

        public static EmailCreator getInst()
        {
            if (uniqueInst == null)
            {
                uniqueInst = new EmailCreator();
            }
            return uniqueInst;
        }

        /// Created by Susan
        /// 30/11/2016
        /// Accepts a vacancy and interview and template type in order to modify a template with dyanmic information and return it to the email bank
        public void GenerateEmail(int m_ID, Vacancy m_vacancy, EmailTemplate m_template, Interview m_interview,
            string m_mdiParentText)
        {
            Email e = new Email();
            Vacancy v = m_vacancy;
            Interview i = m_interview;
            EmailTemplate et = m_template;

            //gets
            e.getID = m_ID;
            e.getTemplateID = et.getID;
            e.getInterviewID = i.getInterviewID;
            e.getAddress = i.getApplicantEmail;
            e.getSubject = et.getSubject;
            
            //Created by Peter - feedback area builder
            string tempContent;
            List<string> feedback = new List<string>();

            for (int index = 0; index < v.getQuestionsToBeUsed.Count; index++)
            {
                Question q = questionbank.getQuestionList.FirstOrDefault(o => o.GetID == v.getQuestionsToBeUsed[index]);
                int score = i.Answers[index];
                int respLoc = score - 1;
                feedback.Add(q.Feedback[respLoc]);
            }

            //content string builder
            tempContent = et.getBody;

            StringBuilder builder = new StringBuilder(tempContent);
            builder.Replace("[IntervieweeName]", i.getApplicantName);
            builder.Replace("[JobRole]", v.Role);
            builder.Replace("[SenderName]", m_mdiParentText.Substring(22, m_mdiParentText.Length - 22));

            string str = "";
            foreach (string s in feedback)
            {
                string strPRE = str;
                str = strPRE + "\r\n" + s;
            }
            str = str + "\r\n";

            builder.Replace("[FeedbackArea]", str);

            string newTempContent = builder.ToString();

            e.getContent = newTempContent;
            e.getSentDate = "Not Yet Sent";

            EB.addEmailToList(e);
        }

        /// <summary>
        /// Created by Dan. 
        /// Slimmed down modification of an email, as some fields cannot be changed once an email is generated.
        /// </summary>
        /// <param name="m_emailID"></param>
        /// <param name="m_address"></param>
        /// <param name="m_subject"></param>
        /// <param name="m_content"></param>
        public void ModifyEmail(int m_emailID, string m_address, string m_subject, string m_content)
        {
            Email e = EB.getEmailList.First(em => em.getID == m_emailID);
            e.getAddress = m_address;
            e.getSubject = m_subject;
            e.getContent = m_content;

            EB.UpdateEmailList(e);
        }

        /// <summary>
        /// Created By Dan. 
        /// Small method that will edit an emails sent date.
        /// </summary>
        /// <param name="m_emailID"></param>
        /// <param name="m_dateSent"></param>
        public void AdjustEmailSentDate(int m_emailID, string m_dateSent)
        {
            Email e = EB.getEmailList.First(em => em.getID == m_emailID);
            e.getSentDate = m_dateSent;

            EB.UpdateEmailList(e);
        }
    }
}
