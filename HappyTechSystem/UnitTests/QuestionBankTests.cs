using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HappyTechSystem.Core;

namespace UnitTests
{
    [TestClass]
    public class QuestionBankTests
    {

        /// <summary>
        /// Created By Peter.
        /// Test that adding a question to the question bank works (Automatically adjusts to QB size)
        /// </summary>
        [TestMethod]
        public void Test_AddTolist()
        {
            QuestionBank QB = new QuestionBank();
            Question Q = new Question();
            int expected = QB.getQuestionList.Count;
            QB.addToList(Q);

            Assert.AreEqual(QB.getQuestionList[expected], Q);
        }

        [TestMethod]
        public void Test_RemoveFromList()
        {
            QuestionBank QB = new QuestionBank();
            Question Q = new Question();
            Q.GetID = 999;
            QB.addToList(Q);


            int expected = QB.getQ.Count - 1;
            QB.removeFromList(999);
            int after = QB.getQ.Count;
            Assert.AreEqual(expected, after);

        }
    }
}
