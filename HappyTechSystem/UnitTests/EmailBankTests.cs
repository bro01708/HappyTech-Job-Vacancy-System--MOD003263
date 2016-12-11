using HappyTechSystem.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]

    public class EmailBankTests
    {
        /// <summary>
        /// Created by Susan
        /// Tests adding a template to the email bank
        /// 02/12/2016

        [TestMethod]

        public void Test_addTemplateToList()
        {
            EmailBank EB = new EmailBank();
            EmailTemplate T = new EmailTemplate();
            int nextID = EB.getHighestTemplateID() + 1;
            T.getID = nextID;
            T.getType = "Test";
            T.getName = "Test";
            T.getBody = "Test";
            T.getSubject = "Test";

            int expected = EB.getTemplateList.Count;
            EB.addTemplateToList(T);

            Assert.AreEqual(EB.getTemplateList[expected], T);

            EB.RemoveTemplate(T.getID);
        }

        /// Created by Susan
        /// Tests adding an email to the email bank list
        /// 04/12/2016
        /// 
        [TestMethod]

        public void Test_addEmailToTlist()
        {

            EmailBank EB = new EmailBank();
            Email E = new Email();
            int nextID = EB.getHighestEmailID() + 1;
            E.getID = nextID;
            E.getAddress = "Test";
            E.getContent = "Test";
            E.getInterviewID = 1;
            E.getSentDate = "Test";
            E.getSubject = "Test";
            E.getTemplateID = 1;

            int expected = EB.getEmailList.Count;
            EB.addEmailToList(E);

            Assert.AreEqual(EB.getEmailList[expected], E);
            string str = E.ToString();                   
            
            EB.RemoveEmail(E.getID);
        }

        [TestMethod]

        public void Test_PDFGen()
        {
            
        }

        [TestMethod]

        public void Test_SendEmail()
        {
            
        }

        //[TestMethod]

        /////Created by Susan
        // ///Tests removing an email template from the email bank
        // ///04/12/2016

        //public void Test_RemoveTemplate()
        //{
        //    EmailBank EB = new EmailBank();
        //    EmailTemplate E = new EmailTemplate();
        //    E.getID = 100;
        //    EB.addTemplateToList(E);

        //    int expected = EB.getTemplateList.Count - 1;
        //    EB.RemoveTemplate(100);
        //    int after = EB.getTemplateList.Count;
        //    Assert.AreEqual(expected, after);
        //}

        //[TestMethod]

        /////Created by Susan
        /////Tests removing an email from the email bank
        /////04/12/2016

        //public void Test_RemoveEmail()
        //{
        //    EmailBank EB = new EmailBank();
        //    Email E = new Email();
        //    E.getID = 100;
        //    EB.addEmailToList(E);

        //    int expected = EB.getEmailList.Count - 1;
        //    EB.RemoveEmail(100);
        //    int after = EB.getEmailList.Count;
        //    Assert.AreEqual(expected, after);
        //}

    }

    
}
