using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private static VacancyBank uniqueInst;

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

        public List<Interview> getInterviewList
        {
            get { return interviewList; }
            set { interviewList = value; }
        }

        /// <summary>
        /// Created By Dan. 
        /// Adds the passed in vacancy into the bank's vacancy list, saving to the database as well.
        /// </summary>
        /// <param name="m_v"></param>
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

        public void UpdateList(Vacancy m_v)
        {
            ml.UpdateVacancyInDB(m_v);
            RefreshDBConnection();
        }

        /// <summary>
        /// Created By Dan. 
        /// Iterates over all vacancies in the local list and find the one that matches the id passed into this method, removing it
        /// </summary>
        /// <param name="m_vacancyID"></param>
        public void RemoveVacancyFromList(int m_vacancyID)
        {
            foreach (Vacancy v in vacancyList)
            {
                if (v.GetID == m_vacancyID)
                {
                    vacancyList.Remove(v);
                    ml.RemoveVacancyFromDB(m_vacancyID);
                    break;
                }
            }
        }

        public void RemoveInterviewFromList(int m_interviewID)
        {
            try
            {
                foreach (Interview i in interviewList)
                {
                    if (i.getInterviewID == m_interviewID)
                    {
                        interviewList.Remove(i);
                        ml.RemoveInterviewFromDB(m_interviewID);
                    }
                }
            }
            catch (Exception)
            {

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
                int vacancyCount = vacancyList.Count;

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
                int interviewCount = interviewList.Count;

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
