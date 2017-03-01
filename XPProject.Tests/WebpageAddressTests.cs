using System;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoleAndParty.Classes;


namespace RoleAndParty.Tests
{
    [TestClass]
    public class WebpageAddressTests
    {
        private WebpageAddress g;
        [TestInitialize]
        public void Init() { g = new WebpageAddress(); }
        [TestCleanup]
        public void Cleanup()
        {
            g = null;
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(new WebpageAddress());
        }

        [TestMethod]
        public void UrlTests()
        {
            var fakeValue = "some kind of Url";
            g.Url = fakeValue;
            Assert.AreEqual(fakeValue, g.Url);
            Assert.AreEqual(typeof(string), g.Url.GetType());
        }

        [TestMethod]
        public void UrlTest()
        {
            var w = new WebpageAddress();
            var u = new Url("www.abc.ee");

            Assert.AreNotEqual(String.Empty, u);




        }

    }
}
