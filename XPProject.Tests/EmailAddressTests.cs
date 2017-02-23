using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoleAndParty;

namespace XPProject.Tests
{
    /// <summary>
    /// Summary description for EmailAddressTests
    /// </summary>
    [TestClass]
    public class EmailAddressTests
    {
        private EmailAddress g;
        [TestInitialize]
        public void Init() { g = new EmailAddress(); }
        [TestMethod]
        public void ConstructorTest() { Assert.IsNotNull(g); }

        //[TestCleanup]
        //EmailAddress g = null;

        [TestMethod]
        public void AttributeTest()
        {
            
        }




        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        
    }
}
