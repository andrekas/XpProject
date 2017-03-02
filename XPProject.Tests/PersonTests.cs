using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoleAndParty.Classes;

namespace XPProject.Tests
{
    [TestClass]
    public class PersonTests
    {

        private Person p;

        [TestInitialize]
        public void Init()
        {
            p = new Person();
        }

        [TestCleanup]
        public void Cleanup()
        {
            p = null;
        }
        
        [TestMethod]
        public void ConstructorTest()
        {

            Assert.IsNotNull(p);
        }
        
        [TestMethod]
        public void NameTests()
        {
            var fakeValue = "some kind of Name";

            p.Name = fakeValue;
            Assert.AreEqual(fakeValue, p.Name);
            Assert.AreEqual(typeof(string), p.Name.GetType());
        }


        [TestMethod]
        public void GenderTests()
        {
            var fakeValue = "some kind of Gender";

            p.Gender = fakeValue;
            Assert.AreEqual(fakeValue, p.Gender);
            Assert.AreEqual(typeof(string), p.Gender.GetType());
        }

        [TestMethod]
        public void DateTimeTests()
        {
            
        }
    }
}
