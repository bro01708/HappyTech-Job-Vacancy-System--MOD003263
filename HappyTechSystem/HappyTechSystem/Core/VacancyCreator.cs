using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem.Core
{
    class VacancyCreator
    {

        public void CreateVacancy(int m_vacancyID, string m_vacancyName, int m_minimumScore, int m_positionsAvailable , List<int>m_Questions)
    {
            Vacancy V = new Vacancy();
            V.Vacancyid = m_vacancyID;
            V.VacancyName = m_vacancyName;
            V.MinumumScore = m_minimumScore;
            V.PositionsAvailable = m_positionsAvailable;
            
    }

    }
    
}
