using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoleAndParty.Classes;

namespace XPProject.Tests
{
    [TestClass]
    public class PersonTests
    {
        private RelationshipType g;
        [TestInitialize]
        public void Init() { g = new RelationshipType(); }
        [TestCleanup]
        public void Cleanup()
        {
            g = null;
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Assert.IsNotNull(g);
            Assert.IsNotNull(new Person());
        }

        [TestMethod]
        public void NameTests()
        {
            var fakeValue = "some kind of Name";
            g.Gender = fakeValue;
            Assert.AreEqual(fakeValue, g.Gender);
            Assert.AreEqual(typeof(string), g.Gender.GetType());
        }
        [TestMethod]
        public void GenderTests()
        {
            var fakeValue = "some kind of Gender";
            g.Gender = fakeValue;
            Assert.AreEqual(fakeValue, g.Gender);
            Assert.AreEqual(typeof(string), g.Gender.GetType());
        }
    }
}
