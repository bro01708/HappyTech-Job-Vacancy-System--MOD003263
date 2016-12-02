using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem.Core
{
    public class Vacancy
    {
        private int vacancyid;
        //private List<Interview> interviews = new List<Interview>();
        private List<int> questionsToBeUsed = new List<int>(); //Stores questionIDs for the interview
        private List<Interview> interviewList = new List<Interview>();
        private int minumumScore;
        private int positionsAvailable;
        private string role;
        private string vacancyName;

        public string VacancyName
        {
            get { return vacancyName; }
            set { vacancyName = value; }
        }

        public int PositionsAvailable
        {
            get { return positionsAvailable; }
            set { positionsAvailable = value; }
        }

        public int MinumumScore
        {
            get { return minumumScore; }
            set { minumumScore = value; }
        }

        public int GetID
        {
            get { return vacancyid; }
            set { vacancyid = value; }
        }

        //internal List<Interview> Interviews
        //{
        //    get
        //    {
        //        return interviews;
        //    }

        //    set
        //    {
        //        interviews = value;
        //    }
        //}

        public List<int> getQuestionsToBeUsed
        {
            get { return questionsToBeUsed; }
            set { questionsToBeUsed = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public void GetRankings() //Ranks every users' final score to find the chosen applicant
        {

        }
        public override string ToString()
        {
            return "(" + vacancyid.ToString() + ") - [" + role + "] - " + vacancyName;
        }

    }
}
