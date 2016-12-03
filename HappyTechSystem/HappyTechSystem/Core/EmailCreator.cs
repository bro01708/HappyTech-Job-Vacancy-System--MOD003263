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
    class EmailCreator
    {
        private VacancyBank vacancyBank = VacancyBank.getInst();
        private QuestionBank questionbank = QuestionBank.getInst();

        private static EmailCreator uniqueInst = null;

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
        public void GenerateEmail(int m_ID, Vacancy m_vacancy, EmailTemplate m_template, Interview m_interview, string m_mdiParentText)
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

            //feedback area builder
            string tempContent;
            List<string> feedback = new List<string>();

            for (int index = 0; index < v.getQuestionsToBeUsed.Count; index++)
            {
                Question q = questionbank.getQuestionList.FirstOrDefault(o => o.GetID == v.getQuestionsToBeUsed[index]);
                int score = i.Answers[index];
                int respLoc = score - 1;
                feedback.Add(q.Responses[respLoc]);
            }

            //content string builder
            tempContent = et.getBody;

            StringBuilder builder = new StringBuilder(tempContent);
            builder.Replace("[IntervieweeName]", i.getApplicantName);
            builder.Replace("[JobRole]", v.Role);
            builder.Replace("[SenderName]", m_mdiParentText.Substring(22, m_mdiParentText.Length - 22));

            //this will need some work to display correctly.
            string str = "";
            foreach (string s in feedback)
            {
                string strPRE = str;
                str = (strPRE + "\r\n" + s);
            }
            str = str + "\r\n";

            builder.Replace("[FeedbackArea]", str);

            string newTempContent = builder.ToString();

            e.getContent = newTempContent;
            e.getSentDate = "Not Yet Sent";

            EmailBank EB = EmailBank.getInst();
            EB.addEmailToList(e);

    }

    }
}
