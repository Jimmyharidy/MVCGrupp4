using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDRetro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;

namespace TDDRetro.Tests
{
    [TestClass()]
    public class MathTests
    {
        [TestMethod()]
        public void CountSquareTest()
        {
            Math countFail = new Math();
            var actual = countFail.CountSquare("5");
            var expected = 25;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void CountSquareCorrect()
        {
            Math square = new Math();
            var acttual = square.CountSquare("2");
            var expected = 4;
            Assert.AreEqual(acttual, expected);
        }

        [TestMethod]
        public void CountSquareZero()
        {
            Math zero = new Math();
            var actual = zero.CountSquare("0");
            var expected = 0;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CountSquareNegative()
        {
            Math negative = new Math();
            var actual = negative.CountSquare("-5");
            var expected = 25;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void CountSquare_WithTextInStringInsteadOfNumber()
        {
            Math textInString = new Math();
            textInString.CountSquare("five");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void CountSquare_WithTextAndNumbers()
        {
            Math textAndNumbers = new Math();
            textAndNumbers.CountSquare("five5");
        }

        [TestMethod]
        public void CountSquare_WithSpaceMethodOne()
        {
            Math numberWithSpace = new Math();
            var actual = numberWithSpace.CountSquare(" 8");
            var expected = 64;
            Assert.AreEqual(actual, expected, "Space + number is correct");
        }

        [TestMethod]
        public void CountSquare_WithSpaceMethodTwo()
        {
            Math numberWithSpace = new Math();
            var actual = numberWithSpace.CountSquare("9 ");
            var expected = 81;
            Assert.AreEqual(actual, expected, "Number + space is correct");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void CountSquare_WithWrongFormat()
        {
            Math multiplyNumberWithNumber = new Math();
            multiplyNumberWithNumber.CountSquare("7*7");
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CountSquare_WithNull()
        {
            Math countWithNull = new Math();
            countWithNull.CountSquare(null);

        }

        
    }
   
}