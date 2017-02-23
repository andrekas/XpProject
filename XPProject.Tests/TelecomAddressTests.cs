using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XPProject.Tests
{
    /// <summary>
    /// Summary description for TelecomAddressTests
    /// </summary>
    [TestClass]
    public class TelecomAddressTests
    {
        private TelecomAddress g;
        [TestInitialize]
        public void Init() { g = new TelecomAddress(); }
        [TestCleanup]
        public void Cleanup()
        {
            g = null;
        }

        [TestMethod]
        public void ConstructorTest() { Assert.IsNotNull(g); }

       
    }
}
