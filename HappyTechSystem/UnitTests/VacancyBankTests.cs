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

        [TestMethod]

        public void Test_AddInterviewToList()
        {
            VacancyBank VB = new VacancyBank();
            Interview I = new Interview();
            int expected = VB.getInterviewList.Count;
            VB.AddInterviewToList(I);

            Assert.AreEqual(VB.getInterviewList[expected], I);
        }

        /// <summary>
        /// Created by Susan
        /// 04/12/2016
        /// //Tests removing a vacancy from the vacancy bank
        /// </summary>

        [TestMethod]

        public void Test_RemoveVacancyFromList()
        {
            VacancyBank VB = new VacancyBank();
            Vacancy I = new Vacancy();
            I.GetID = 100;
            VB.AddVacancyToList(I);

            int expected = VB.getVacancyList.Count - 1;
            VB.RemoveVacancyFromList(100);
            int after = VB.getVacancyList.Count;
            Assert.AreEqual(expected, after);

        }
      


    }
}
