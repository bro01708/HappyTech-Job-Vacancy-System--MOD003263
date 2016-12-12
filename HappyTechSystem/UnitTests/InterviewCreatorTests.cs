using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HappyTechSystem.Core;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class InterviewCreatorTests
    {
        [TestMethod]
        public void CreateInterviewTest()
        {
            VacancyBank VB1 = new VacancyBank();
            VacancyBank VB = VacancyBank.getInst();
            VacancyCreator VC = VacancyCreator.getInst();
            int nextVACid = VB.getHighestVacancyID() + 1;
            int nextINTid = VB.getHighestInterviewID() + 1;
            List<int> qtbu = new List<int>(new int[] { 1, 2, 3, 4, 5 });

            VC.CreateModifyVacancy(nextVACid, "test", "tester", 10, 1, qtbu, 0);
            
            InterviewCreator IC = new InterviewCreator();
            IC.CreateInterview(nextINTid, nextVACid, "peter", "test", "test", "test", "test", "test", qtbu.ToArray(), 50);

            Assert.AreEqual(nextINTid, VB.getInterviewList.Last<Interview>().getInterviewID);

        }
    }
}
