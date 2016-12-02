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
            int expected = EB.getTemplateList.Count;
            EB.addTemplateToList(T);

            Assert.AreEqual(EB.getTemplateList[expected], T);

        }


        }

    
}
