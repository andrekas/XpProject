﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoleAndParty.Aids;

namespace XPProject.Tests
{
    [TestClass]
    public class StrTests
    {
        [TestMethod]
        public void EmptyIfNullTest()
        {
            Assert.AreEqual(string.Empty, Str.EmptyIfNull(null));
            Assert.AreEqual(" ", Str.EmptyIfNull(" "));
        }
    }
}
