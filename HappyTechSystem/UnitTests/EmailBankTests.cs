using HappyTechSystem.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTests
{
    [TestClass]

    public class EmailBankTests
    {
        /// <summary>
        /// Created by Dan
        /// Tests adding a template to the email bank
        /// 02/12/2016

        [TestMethod]

        public void Test_addTemplateToList()
        {
            EmailBank EB = EmailBank.getInst();
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

            EmailBank EB = EmailBank.getInst();
            EmailCreator EC = EmailCreator.getInst();
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
        /// <summary>
        /// Created By peter to test generation of pdfs , sets  uo temp emailbank and email , 
        /// runs the generation and tests to see if the file exists.
        /// </summary>
        [TestMethod]
      
        public void Test_PDFGen()
        {
            EmailBank eb = EmailBank.getInst();
            Email m_email = new Email();
            m_email.getID = 9999999;
            m_email.getAddress = "bro01708@gmail.com";
            m_email.getSubject = "testsubject";
            m_email.getContent = "testcontent";
            m_email.getInterviewID = 999999;
            eb.PDFGen(m_email);
            bool fileexists = false;
            if(File.Exists(Environment.CurrentDirectory + "\\StoredEmails\\" + m_email.getInterviewID + " - " + m_email.getAddress + " - Email_Copy.pdf"))
            {
                fileexists = true;
            }
            Assert.AreEqual(true, fileexists);
        }

        [TestMethod]

        public void Test_SendEmail()
        {
            EmailBank eb = EmailBank.getInst();
            Email m_email = new Email();
            m_email.getID = 9999999;
            m_email.getAddress = "bro01708@gmail.com";
            m_email.getSubject = "testsubject";
            m_email.getContent = "testcontent";
            m_email.getInterviewID = 999999;
            bool noerrors;
            try {eb.SendEmail(m_email); noerrors = true; } catch { noerrors = false; }
            Assert.AreEqual(true, noerrors);
            
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
