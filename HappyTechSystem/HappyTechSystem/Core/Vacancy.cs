using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem.Core
{
    class Vacancy
    {
        private int vacancyid;
        private List<Interview> interviews = new List<Interview>();
        private List<Question> questionsToBeUsed = new List<Question>(); //Stores questions for the interview
        private int minumumScore;
        private int positionsAvailable;
        private string vacancyName;

        public string VacancyName
        {
            get
            {
                return vacancyName;
            }

            set
            {
                vacancyName = value;
            }
        }

        public int PositionsAvailable
        {
            get
            {
                return positionsAvailable;
            }

            set
            {
                positionsAvailable = value;
            }
        }

        public int MinumumScore
        {
            get
            {
                return minumumScore;
            }

            set
            {
                minumumScore = value;
            }
        }

        public int Vacancyid
        {
            get
            {
                return vacancyid;
            }

            set
            {
                vacancyid = value;
            }
        }

        internal List<Interview> Interviews
        {
            get
            {
                return interviews;
            }

            set
            {
                interviews = value;
            }
        }

        public void Rankings() //Ranks every users' final score to find the chosen applicant
        {
            RefreshRankings
        }

        
    }
}
