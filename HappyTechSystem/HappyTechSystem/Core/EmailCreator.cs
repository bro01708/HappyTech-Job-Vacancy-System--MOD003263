using HappyTechSystem.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTechSystem.Core
{
    class EmailCreator
    {
        private VacancyBank vacancyBank = VacancyBank.getInst();
        private EmailTemplate emailTemplate;
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
        public void GenerateEmail(Vacancy m_vacancy, EmailTemplate m_template, Interview m_interview, string m_mdiParentText)
        {
            Email e = new Email();

            Vacancy v = m_vacancy;
            Interview i = m_interview;
            string tempContent;
            List<string> feedback = new List<string>();
            emailTemplate = m_template;
            //gets
            //e.getAddress = ;
            e.getSubject = emailTemplate.getSubject;
            //feedback area builder

            for (int index = 0; index < v.getQuestionsToBeUsed.Count; index++)
            {
                Question q = questionbank.getQuestionList.FirstOrDefault(o => o.GetID == v.getQuestionsToBeUsed[index]);

                feedback.Add(q.Responses[i.Answers[index]]);

            }

            //content string builder
            tempContent = emailTemplate.getBody;
            tempContent.Replace("[InterviewerName]", i.getApplicantName);
            tempContent.Replace("[JobRole]", v.Role);
            tempContent.Replace("[SenderName]", m_mdiParentText.Substring(22, m_mdiParentText.Length - 22));

            //this will need some work to display correctly.
            tempContent.Replace("[FeedbackArea]", feedback.ToString());
            e.getContent = tempContent;

            EmailBank EB = EmailBank.getInst();
            EB.addEmailToList(e);

    }

    }
}
