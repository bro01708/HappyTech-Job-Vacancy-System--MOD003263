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

        public void CreateInterview(int m_ID, int m_vacancyID, string m_interviewerName, string m_applicantTitle, string m_applicantName, string m_applicantEmail, string m_cvPath, string m_notes, int[] m_questionAnswers)
        {
            Interview I = new Interview();
            I.getInterviewID = m_ID;
            I.getUsedVacancyID = m_vacancyID;
            I.getInterviewerName = m_interviewerName;
            I.getApplicantTitle = m_applicantTitle;
            I.getApplicantName = m_applicantName;
            I.getApplicantEmail = m_applicantEmail;
            I.getCVPath = m_cvPath;        
            I.getAdditionalNotes = m_notes;
            I.Answers = m_questionAnswers;
            VacancyBank VB = VacancyBank.getInst();
            VB.AddInterviewToList(I);
        }
    }
}
