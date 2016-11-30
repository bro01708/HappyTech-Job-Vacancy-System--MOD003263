using HappyTechSystem.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem.Core
{
    class EmailCreator
    {
        private VacancyBank vacancyBank = VacancyBank.getInst();
        private EmailTemplate emailTemplate;

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
        public void GenerateEmail(Vacancy m_vacancy, EmailTemplate m_template, Interview m_interview)
        {
            Email e = new Email();
            Vacancy v = m_vacancy;
            Interview i = m_interview;
            string tempContent;
            emailTemplate = m_template;

            //gets
            //e.getAddress = ;
            e.getSubject = emailTemplate.getSubject;
            //feedback area builder

            //content string builder
            tempContent = emailTemplate.getBody;
            tempContent.Replace("[IN]", i.getApplicantName);
            tempContent.Replace("[JR]", v.Role);
            //tempContent.Replace("[FA]", );
            e.getContent = tempContent;

            EmailBank EB = EmailBank.getInst();
            EB.addEmailToList(e);

    }

    }
}
