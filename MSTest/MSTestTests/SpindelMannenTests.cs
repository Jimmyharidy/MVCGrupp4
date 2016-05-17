using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest.Tests
{
    [TestClass()]
    public class SpindelMannenTests
    {
        [TestMethod()]
        public void GetCircumFerenceTest()
        {
            SpindelMannen parker = new SpindelMannen();
           var actual = parker.GetCircumFerence(3.3);
            var expected = 20.734511513692635M;

            Assert.AreEqual(expected, actual);
        }
    }
}