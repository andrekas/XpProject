﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoleAndParty.Classes;

namespace XPProject.Tests
{
    [TestClass]
    public class ArchetypesTests
    {


        private Archetypes<Archetype> g;
        [TestInitialize]
        public void Init() { g = new Archetypes<Archetype>(); }
        [TestCleanup]
        public void Cleanup()
        {
            g = null;
        }

        [TestMethod]
        public void CanAdd()
        {
            var a = new Archetype();
            g.Add(a);
            Assert.AreEqual(1, g.Count);
        }

        [TestMethod]
        public void CanRemove()
        {
            var a = new Archetype();
            g.Remove(a);
            Assert.AreEqual(0, g.Count);
        }

        [TestMethod]
        public void CanClear()
        {

            g.Clear();
            Assert.AreEqual(0, g.Count);
        }

        //[TestMethod]
        //public void ContainsTest()
        //{
        //    var a = new Archetype();
        //    g.Add(a);
        //    Assert.AreEqual();

        //}

    }

}
