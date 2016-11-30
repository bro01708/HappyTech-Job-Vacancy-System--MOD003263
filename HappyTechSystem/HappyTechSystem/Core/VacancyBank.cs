using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappyTechSystem.DB;

namespace HappyTechSystem.Core
{
    class VacancyBank
    {
        private List<Vacancy> vacancyList;
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
            get
            {
                return vacancyList;
            }

            set
            {
                vacancyList = value;
            }
        }
        
        public void AddToList(Vacancy m_v)
        {
            vacancyList.Add(m_v);
            ml.SaveVacancyToDB(m_v);
            
        }
        
        public void RemoveFromList(int m_i)
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
                return vacancyList[vacancyCount - 1].GetID;

            }
            catch (Exception e)
            {

                throw e;
            }
        }

    }
}
