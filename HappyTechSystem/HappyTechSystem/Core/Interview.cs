using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem.Core
{
    /// <summary>
    /// Created by Susan
    /// Forms the Interview type, with relevant fields to match
    /// </summary>
    public class Interview
    {
        private int interviewID, usedVacancyID;
        private string interviewerName, applicantTitle, applicantName, applicantEmail, cvPath, additionalNotes;
        private int[] ranks;


        public int getUsedVacancyID
        {
            get { return usedVacancyID;} 
            set { usedVacancyID = value; }
        }

        public string getInterviewerName
        {
            get { return interviewerName;}
            set { interviewerName = value; }
        }

        public string getApplicantTitle
        {
            get { return applicantTitle; }
            set { applicantTitle = value; }
        }

        /// <summary>
        /// Created by Susan
        /// </summary>
        public string getApplicantName
        {
            get { return applicantName; }
            set { applicantName = value; }
        }

        /// <summary>
        /// Created by Susan
        /// allows the applicant email string to be called elsewhere
        /// </summary>
        public string getApplicantEmail
        {
            get { return applicantEmail; }
            set { applicantEmail = value; }
        }

        public string getCVPath
        {
            get { return cvPath; }
            set { cvPath = value; }
        }
        public string getAdditionalNotes
        {
            get { return additionalNotes; }
            set { additionalNotes = value; }
        }

        public int getInterviewID
        {
            get { return interviewID; }
            set { interviewID = value; }
        }

        public int[] getRanks
        {
            get { return ranks; }
            set { ranks = value; }
        }
        public void AttachCV() //Attaches CV of applicant to be interviewed
        {
            
        }

        public void CalculateScore() //Adds up users points to make final score
        {

        }

        public void SelectVacancy() //Selects which vacancy the interview is for
        {

        }

        public void StoreRecords() //Stores applicants personal details
        {

        }
    }
}
