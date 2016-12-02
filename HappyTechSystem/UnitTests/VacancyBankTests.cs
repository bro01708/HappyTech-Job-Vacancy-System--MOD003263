using Microsoft.VisualStudio.TestTools.UnitTesting;
using HappyTechSystem.Core;
using System;

namespace UnitTests
{
    [TestClass]

    public class VacancyBankTests
    {
        /// Created by Susan
        /// Tests adding a vacancy to the vacancy bank
        /// 02/12/2016

        [TestMethod]

        public void Test_AddVacancyToList()
        {
            VacancyBank VB = new VacancyBank();
            Vacancy V = new Vacancy();
            int expected = VB.getVacancyList.Count;
            VB.AddVacancyToList(V);

            Assert.AreEqual(VB.getVacancyList[expected], V);
        }

        /// Created by Susan
        /// Tests adding an interview to the vacancy bank
        /// 02/12/2016

        public void Test_AddInterviewToList()
        {
            VacancyBank VB = new VacancyBank();
            Interview I = new Interview();
            int expected = VB.getInterviewList.Count;
            VB.AddInterviewToList(I);

            Assert.AreEqual(VB.getInterviewList[expected], I);
        }


    }
}
