using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyTechSystem.DB;

namespace HappyTechSystem.Core
{
    public class VacancyBank
    {
        private List<Vacancy> vacancyList;
        private List<Interview> interviewList;
        private MetaLayer ml = MetaLayer.instance();
        private bool dbLoaded;

        public VacancyBank()
        {
            RefreshDBConnection();
        }

        public bool getDBLoaded
        {
            get { return dbLoaded; }
        }

        private static VacancyBank uniqueInst = null;

        public static VacancyBank getInst()
        {
            if (uniqueInst == null)
            {
                uniqueInst = new VacancyBank();
            }
            return uniqueInst;
        }

        public List<Vacancy> getVacancyList
        {
            get { return vacancyList; }
            set { vacancyList = value; }
        }

        public List<Interview> getInterivewList
        {
            get { return interviewList; }
            set { interviewList = value; }
        }

        public void AddVacancyToList(Vacancy m_v)
        {
            vacancyList.Add(m_v);
            ml.SaveVacancyToDB(m_v);
        }

        public void AddInterviewToList(Interview m_i)
        {
            interviewList.Add(m_i);
            ml.SaveInterviewToDB(m_i);
        }

        public void RemoveVacancyFromList(int m_i)
        {
            foreach (Vacancy v in vacancyList)
            {
                if (v.GetID == m_i)
                {
                    vacancyList.Remove(v);
                }
            }
        }

        public void RefreshDBConnection()
        {
            try
            {
                MetaLayer ml = MetaLayer.instance();
                vacancyList = ml.GetVacancies();
                interviewList = ml.GetInterviews();
                dbLoaded = true;
            }
            catch (Exception e)
            {
                dbLoaded = false;
                throw e;
            }
        }

        public int getHighestVacancyID()
        {
            try
            {
                int vacancyCount = vacancyList.Count();

                if (vacancyCount == 0)
                {
                    return vacancyCount;
                }

                return vacancyList[vacancyCount - 1].GetID;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int getHighestInterviewID()
        {
            try
            {
                int interviewCount = interviewList.Count();

                if (interviewCount == 0)
                {
                    return interviewCount;
                }
                return interviewList[interviewCount - 1].getInterviewID;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
