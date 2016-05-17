using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MVCExercise
{
    public class Calculator
    {
        public int Add(string number1, string number2)
        {
            return int.Parse(number1 + number2);
        }
        [TestFixture]
        public class CalculatorTest
        {
            [Test]
            public void summary()
            {
                Calculator number = new Calculator();
                var actual = number.Add("2", "3");
                var expected = 5;
                Assert.That(actual, Is.EqualTo(expected));


            }

        }

    }
}
