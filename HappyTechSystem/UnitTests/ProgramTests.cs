using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HappyTechSystem.Core;
using HappyTechSystem.Forms;


namespace UnitTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void TestMain()
        {
            bool success = false;
            try
            {
                Program.Main();
                success = true;
                
            }
            catch { success = false; }

            Assert.AreEqual(true, success);
            
        }
    }
}
