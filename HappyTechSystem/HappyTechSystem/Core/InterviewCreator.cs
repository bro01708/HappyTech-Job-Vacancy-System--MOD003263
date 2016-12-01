using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem.Core
{
    class InterviewCreator
    {
        private static InterviewCreator uniqueInst;

        public static InterviewCreator getInst()
        {
            if (uniqueInst == null)
            {
                uniqueInst = new InterviewCreator();
            }
            return uniqueInst;
        }

        public void CreateInterview(int m_ID, int m_vacancyID, string m_interviewerName, string m_applicantTitle, string m_applicantName, string m_cvPath, string m_notes)
        {
            Interview I = new Interview();
            I.getInterviewID = m_ID;
            I.getUsedVacancyID = m_vacancyID;
            I.getInterviewerName = m_interviewerName;
            I.getApplicantTitle = m_applicantTitle;



        }
    }
}
