using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem.Core
{
    class Interview
    {
        private string applicantEmailAddress, applicantFirstName, applicantLastName, applicantTitle, cv;
        private int id;

        public string ApplicantEmailAddress
        {
            get
            {
                return applicantEmailAddress;
            }

            set
            {
                applicantEmailAddress = value;
            }
        }

        public string ApplicantFirstName
        {
            get
            {
                return applicantFirstName;
            }

            set
            {
                applicantFirstName = value;
            }
        }

        public string ApplicantLastName
        {
            get
            {
                return applicantLastName;
            }

            set
            {
                applicantLastName = value;
            }
        }

        public string ApplicantTitle
        {
            get
            {
                return applicantTitle;
            }

            set
            {
                applicantTitle = value;
            }
        }

        public string Cv
        {
            get
            {
                return cv;
            }

            set
            {
                cv = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
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
