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
            VacancyBank VB = VacancyBank.getInst();
            Vacancy V = new Vacancy();
            int nextID = VB.getHighestVacancyID() + 1;
            V.GetID = nextID;
            V.VacancyName = "Test";
            V.Role = "Test";
            V.MinumumScore = 10;
            V.PositionsAvailable = 1;

            int expected = VB.getVacancyList.Count;
            VB.AddVacancyToList(V);

            Assert.AreEqual(VB.getVacancyList[expected], V);

            VB.RemoveVacancyFromList(V.GetID);
        }

        /// Created by Susan
        /// Tests adding an interview to the vacancy bank
        /// 02/12/2016

        [TestMethod]

        public void Test_AddInterviewToList()
        {
            VacancyBank VB = VacancyBank.getInst();
            Interview I = new Interview();
            int nextID = VB.getHighestInterviewID() + 1;
            I.getInterviewID = nextID;
            I.getUsedVacancyID = 1;
            I.getTotal = 1337;
            I.getInterviewerName = "Test";
            I.getApplicantTitle = "Test";
            I.getApplicantName = "Test";
            I.getApplicantEmail = "Test";
            I.getCVPath = "Test";
            I.getAdditionalNotes = "Test";

            int[] answers = new int[5];
            answers[0] = 5;
            answers[1] = 5;
            answers[2] = 5;
            answers[3] = 5;
            answers[4] = 5;

            I.Answers = answers;

            int expected = VB.getInterviewList.Count;
            VB.AddInterviewToList(I);

            Assert.AreEqual(VB.getInterviewList[expected], I);
        }
    }
}
