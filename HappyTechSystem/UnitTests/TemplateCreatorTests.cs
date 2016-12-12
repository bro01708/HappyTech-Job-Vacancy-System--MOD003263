using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using HappyTechSystem.Core;

namespace UnitTests
{
    /// <summary>
    /// Summary description for TemplateCreatorTests
    /// </summary>
    [TestClass]
    public class TemplateCreatorTests
    {

        [TestMethod]
        public void CreateTemplateTest()
        {
            EmailBank EB1 = new EmailBank();
            EmailBank EB = EmailBank.getInst();
            TemplateCreator TC = TemplateCreator.getInst();
            int nextid = EB.getHighestTemplateID() + 1;

            TC.CreateModifyTemplate(nextid, "TESTYPE", "TEST", "TEST", "TEST", 0);

            Assert.AreEqual(nextid , EB.getTemplateList.Last<EmailTemplate>().getID);
        }
    }
}
