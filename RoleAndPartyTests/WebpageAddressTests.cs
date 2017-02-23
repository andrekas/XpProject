using System;
using System.Security.Policy;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoleAndParty.Classes;


namespace RoleAndParty.Tests
{
    [TestClass]
    public class WebpageAddressTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(new WebpageAddress());
        }

        [TestMethod]
        public void UrlTest() {
            var w = new WebpageAddress();
            var u = new Url("www.abc.ee");
            
            Assert.AreNotEqual(String.Empty, u);
            



        }
        
    }
}
