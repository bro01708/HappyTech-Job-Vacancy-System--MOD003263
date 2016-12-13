using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTechSystem.Core
{
    public class VacancyCreator
    {

        public VacancyCreator()
        {

        }
        private static VacancyCreator uniqueInst;
        public static VacancyCreator getInst()
        {
            if (uniqueInst == null)
            {
                uniqueInst = new VacancyCreator();
            }
            return uniqueInst;
        }
        /// <summary>
        /// Created By Peter
        /// Interprets information from ui, creates the Vacancy and passes it through to VacancyBank to store.
        /// 
        /// -- Edit by Dan
        /// Allows both creation and modification of a vacancy, using a flag to determine what operation to perform.
        /// </summary>
        /// <param name="m_vacancyID"></param>
        /// <param name="m_vacancyName"></param>
        /// <param name="m_minimumScore"></param>
        /// <param name="m_positionsAvailable"></param>
        /// <param name="m_Questions"></param>
        public void CreateModifyVacancy(int m_vacancyID, string m_vacancyName, string m_role, int m_minimumScore, int m_positionsAvailable , List<int>m_questionIDs, int flag)
    {
            Vacancy V = new Vacancy();
            V.GetID = m_vacancyID;
            V.VacancyName = m_vacancyName;
            V.Role = m_role;
            V.MinumumScore = m_minimumScore;
            V.PositionsAvailable = m_positionsAvailable;
            V.getQuestionsToBeUsed = m_questionIDs;
            VacancyBank VB = VacancyBank.getInst();

        if (flag == 0)
        {
            VB.AddVacancyToList(V);
        }
        else
        {
            VB.UpdateList(V);
        }

    }

    }
    
}
