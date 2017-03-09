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
    public class ISOGenderTests
    {
        private ISOGender g;

        [TestInitialize]
        public void Init()
        {
            g = new ISOGender();
        }

        [TestMethod]
        public void ConstructorTest() { Assert.IsNotNull(g); }



        //[TestMethod]
        //public void EnumTests()
        //{
        //Assert
        //}

    }
}