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
        private int interviewID, vacancyID, totalScore;
        private string interviewerName, applicantTitle, applicantName, applicantEmail, cvPath, additionalNotes;
        private int[] answers;


        public int getUsedVacancyID
        {
            get { return vacancyID;} 
            set { vacancyID = value; }
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
        /// Getter for applicant name
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

        public int[] Answers
        {
            get { return answers; }
            set { answers = value; }
        }

        public int getTotal
        {
            get { return totalScore; }
            set { totalScore = value; }
        }

        public override string ToString()
        {
            return "(" + interviewID.ToString() + ") - [Score: " + totalScore + "] - " + applicantName;
        }
    }
}
