﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoleAndParty.Tests
{
    /// <summary>
    /// Summary description for RelationshipTypeTests
    /// </summary>
    [TestClass]
    public class RelationshipTypeTests
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
        public void ConstructorTest() { Assert.IsNotNull(g); }

        [TestMethod]
        public void NameTests()
        {
            var fakeValue = "some kind of Name";
            g.Name = fakeValue;
            Assert.AreEqual(fakeValue, g.Name);
            Assert.AreEqual(typeof(string), g.Name.GetType());
        }

        [TestMethod]
        public void DescriptionTests()
        {
            var fakeValue = "some kind of Description";
            g.Description = fakeValue;
            Assert.AreEqual(fakeValue, g.Description);
            Assert.AreEqual(typeof(string), g.Description.GetType());
        }


    }
}
