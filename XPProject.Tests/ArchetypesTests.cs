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
        public void ConstructorTest() { Assert.IsNotNull(g); }

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
            var b = new Archetype();
            g.Add(a);
            g.Add(b);
            g.Remove(a);
            Assert.IsFalse(g.Contains(a));
            Assert.IsTrue(g.Contains(b));
            Assert.AreEqual(1, g.Count);
        }

        [TestMethod]
        public void CanClear()
        {
            var a = new Archetype();
            g.Add(a);
            Assert.AreEqual(1, g.Count);
            g.Clear();
            Assert.AreEqual(0, g.Count);
        }

        [TestMethod]
        public void ContainsTest()
        {
            var a = new Archetype();
            g.Add(a);
            Assert.IsTrue(g.Contains(a));
        }

        [TestMethod]
        public void IndexOfTest()
        {
            var a = new Archetype();
            g.Add(a);
            Assert.AreEqual(0, g.IndexOf(a));
        }

        [TestMethod]
        public void InsertTest()
        {
            var a = new Archetype();
            g.Insert(0, a);
            Assert.IsTrue(g.Contains(a));
            Assert.AreEqual(0, g.IndexOf(a));
        }

        [TestMethod]
        public void RemoveAtTest()
        {
            var a = new Archetype();
            g.Add(a);
            g.Remove(a);
            Assert.IsFalse(g.Contains(a));
        }

        [TestMethod]
        public void CopyToTest()
        {
            var a = new Archetype[2] {new Archetype(), new Archetype()};
            g.CopyTo(a, 0);
            for (var i = 0; i < a.Length; i++)
                Assert.AreEqual(a[i], g[i]);
        }

    }
        //OPENIST testinäide
        //AddTest();
        //    ClearDoOnChanged();
        //var a = new string[Obj.Count];
        //Obj.CopyTo(a, 0);
        //    for (var i = 0; i<a.Length; i++)
        //        Assert.AreEqual(a[i], Obj[i]);
        //    TestDoOnChange();

    }



