using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HappyTechSystem.Core;
using System.Linq;


namespace UnitTests
{
    /// <summary>
    /// Summary description for QuestionCreatorTests
    /// </summary>
    [TestClass]
    public class QuestionCreatorTests
    {

        [TestMethod]
        public void TestCreateQuestion()
        {
            QuestionBank QB = QuestionBank.getInst();
            QuestionCreator QC = QuestionCreator.getInst();
            int nextid = QB.getHighestQuestionID() + 1;
            string[] responses = new string[] { "test", "test", "test", "test", "test", };
            string[] feedback = new string[] { "test", "test", "test", "test", "test", };
            QC.CreateModifyQuestion(nextid, "test", "test",responses,feedback, 0);

            Assert.AreEqual(nextid , QB.getQuestionList.Last<Question>().GetID);
            
        }
    }
}
