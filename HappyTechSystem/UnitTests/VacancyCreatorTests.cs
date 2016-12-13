using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HappyTechSystem.Core;
using System.Linq;

namespace UnitTests
{
    /// <summary>
    /// Summary description for VacancyCreatorTests
    /// </summary>
    [TestClass]
    public class VacancyCreatorTests
    {
       
        /// <summary>
        /// created by peter to test the creation and addition of vacancies to the vacancybank.
        /// </summary>
        [TestMethod]
        public void CreateVacancyTest()
        {
            VacancyBank VB1 = new VacancyBank();
            VacancyBank VB = VacancyBank.getInst();
            VacancyCreator VC = VacancyCreator.getInst();
            int nextid = VB.getHighestVacancyID() + 1;
            List<int> qtbu = new List<int>(new int[] { 1, 2, 3, 4, 5 });


            VC.CreateModifyVacancy(nextid, "test","tester" , 10,1,qtbu,0);

            Assert.AreEqual(nextid , VB.getVacancyList.Last<Vacancy>().GetID);
        }
    }
}
