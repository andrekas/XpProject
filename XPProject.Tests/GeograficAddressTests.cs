using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XPProject.Tests
{
    [TestClass]
    public class GeograficAddressTests
    {
        private GeograficAddress g;
        [TestInitialize]
        public void Init() { g = new GeograficAddress(); }
        [TestMethod]
        public void ConstructorTest() { Assert.IsNotNull(g); }

        private string addressLines;
        
        [TestMethod]
        public void AddressLinesTest()
        {
            var fakeValue = "some kind of address";
            g.AddressLines = fakeValue;
            Assert.AreEqual(fakeValue, g.AddressLines);
            Assert.AreEqual(typeof(string), g.AddressLines.GetType());
        }
        //[TestMethod]
        //public void AddressLinesTypeTest()
        //{
        //    var fakeValue = "some kind of address";
        //    g.AddressLines = fakeValue;
        //    Assert.AreEqual(typeof(string), g.AddressLines.GetType());
        //}
    }
}
