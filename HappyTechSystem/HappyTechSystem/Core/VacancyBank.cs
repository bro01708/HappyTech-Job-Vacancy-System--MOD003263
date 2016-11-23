using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem.Core
{
    class VacancyBank
    {
        private List<Vacancy> vacancyList;

        public VacancyBank()
        {

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


    }
}
