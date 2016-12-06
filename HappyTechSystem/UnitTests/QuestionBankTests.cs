using System;
using System.Runtime.Remoting.Messaging;
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
        public void Test_AddQuestionToList()
        {
            QuestionBank QB = QuestionBank.getInst();
            Question Q = new Question();
            int nextID = QB.getHighestQuestionID() + 1;
            Q.GetID = nextID;
            Q.GetTag = "Test";
            Q.GetText = "Test";
            string[] resp = new string[5];
            string[] feed = new string[5];
            resp[0] = "r1";
            resp[1] = "r2";
            resp[2] = "r3";
            resp[3] = "r4";
            resp[4] = "r5";
            feed[0] = "f1";
            feed[1] = "f2";
            feed[2] = "f3";
            feed[3] = "f4";
            feed[4] = "f5";
            Q.Responses = resp;
            Q.Feedback = feed;

            int expected = QB.getQuestionList.Count;
            QB.addToList(Q);

            Assert.AreEqual(QB.getQuestionList[expected], Q);

            QB.removeFromList(Q.GetID);
        }
    }
}
