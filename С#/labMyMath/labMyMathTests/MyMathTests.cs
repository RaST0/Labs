using Microsoft.VisualStudio.TestTools.UnitTesting;
using labMyMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labMyMath.Tests
{
    [TestClass()]
    public class MyMathTests
    {
        [TestMethod()]
        public void AddTest()
        {
            int a = 3;
            int b = 2;
            int r = 5;

            int rr = MyMath.Add(a, b);

            Assert.AreEqual(r, rr);
        }
        [TestMethod()]
        public void AddBTest()
        {
            int a = -3;
            int b = -1;
            int r = -4;

            int rr = MyMath.Add(a, b);

            Assert.AreEqual(r, rr);
        }

        [TestMethod()]
        public void Add2Test()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SubTest()
        {
            Assert.Fail();
        }
    }
}