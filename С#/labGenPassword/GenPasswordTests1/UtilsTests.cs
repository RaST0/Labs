using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenPassword.Tests
{
    [TestClass()]
    public class UtilsTests
    {
        [TestMethod()]
        public void AddTest()
        {
            int aLength = 7;
            bool aLower = true;
            bool aUpper = true;
            bool aNumber = true;
            bool aSpec = true;
            bool aRus = true;

            Utils.RandomStr((int)aLength, aLower, aUpper, aNumber, aSpec, aRus));

            //Assert.AreEqual();
        }


    }
}