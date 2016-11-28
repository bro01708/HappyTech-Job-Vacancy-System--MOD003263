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

        public List<Vacancy> VacancyList
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
        }
        
        public void RemoveFromList(int m_i)
        {
            foreach (Vacancy v in vacancyList)
            {
                if (v.Vacancyid == m_i)
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


    }
}
