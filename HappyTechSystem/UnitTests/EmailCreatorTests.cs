using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HappyTechSystem.Core;

namespace UnitTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class EmailCreatorTests
    {
        /// <summary>
        /// Created By peter , sets up a temporary environment and parameters for the method to use and then 
        /// runs the generation method.
        /// </summary>
        [TestMethod]
        public void GenerateEmailTest()
        {
            
                EmailBank EB = EmailBank.getInst();
                EmailCreator EC = EmailCreator.getInst();
                Vacancy V = new Vacancy();
                List<int> qtbu = new List<int>(new int[] { 1, 2, 3, 4, 5 });
                V.getQuestionsToBeUsed = qtbu;
                EmailTemplate ET = new EmailTemplate();
                Interview I = new Interview();
                int nextID = EB.getHighestTemplateID() + 1;
                I.Answers = qtbu.ToArray();
                I.getApplicantEmail = "bro01708@gmail.com";
                ET.getID = nextID;
                ET.getType = "Test";
                ET.getName = "Test";
                ET.getBody = "Test";
                ET.getSubject = "Test";
                int newemailID = EB.getHighestEmailID();
                EC.GenerateEmail(newemailID, V, ET, I, "testtesttesttesttesttesttesttesttesttesttesttesttesttest");
                
        }
    }
}
