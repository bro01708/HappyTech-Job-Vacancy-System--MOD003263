using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HappyTechSystem.DB;
using HappyTechSystem.Core;

namespace UnitTests
{
    /// <summary>
    /// Summary description for MetaLayerTests
    /// </summary>
    [TestClass]
    public class MetaLayerTests
    {

        [TestMethod]
        public void TestGetEmails()
        {
            bool success;
            try
            {
                MetaLayer ml = MetaLayer.instance();
                List<Email> EL = ml.GetEmails();
                success=true;
            }
            catch
            {
                success = false;
            }
            Assert.AreEqual(true, success);
        }

        [TestMethod]
        public void TestCheckCategory()
        {
            MetaLayer ml = MetaLayer.instance();
            bool success = false;
            try
            {
                ml.CheckCategories("General");
                success = true;
            }
            catch { success = false; };

            Assert.AreEqual(true, success);

        }

        [TestMethod]
        public void TestUpdateQuestionInDB()
        {
            bool success = false;
            try
            {
                QuestionBank QB = QuestionBank.getInst();
                QuestionCreator QC = QuestionCreator.getInst();
                int nextid = QB.getHighestQuestionID() + 1;
                string[] responses = new string[] { "test", "test", "test", "test", "test", };
                string[] feedback = new string[] { "test", "test", "test", "test", "test", };
                QC.CreateModifyQuestion(nextid, "test", "test", responses, feedback, 0);
                QC.CreateModifyQuestion(nextid, "test", "test", responses, feedback, 1);
                success = true;
            }
            catch { success = false; };

            Assert.AreEqual(true, success);

        }


        [TestMethod]
        public void TestUpdateVacancyInDB()
        {
            bool success = false;
            try
            {
                VacancyBank VB1 = new VacancyBank();
                VacancyBank VB = VacancyBank.getInst();
                VacancyCreator VC = VacancyCreator.getInst();
                int nextid = VB.getHighestVacancyID() + 1;
                List<int> qtbu = new List<int>(new int[] { 1, 2, 3, 4, 5 });
                VC.CreateModifyVacancy(nextid, "test", "tester", 10, 1, qtbu, 0);
                VC.CreateModifyVacancy(nextid, "test", "tester", 10, 1, qtbu, 1);
                success = true;
            }
            catch { success = false; };

            Assert.AreEqual(true, success);
        }

    }
}
