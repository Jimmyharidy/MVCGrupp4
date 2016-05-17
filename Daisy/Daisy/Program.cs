using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Daisy
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public int Add(int a, int b)
        {
            return a + b;
            
        }

        public int SocialNumber(int socialNumber)
        {
            return socialNumber;
        }
    }
    //Datum:ååmmdd  00 - år 16



    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void AddRight()
        {
            // Arrange
            var prog = new Program();
            //Act
            var actual = prog.Add(3, 4);
            var expected = 7;
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void AddWrong()
        {
            // Arrange
            var prog = new Program();
            //Act
            var actual = prog.Add(5, 4);
            var expected = 7;
            //Assert
            Assert.That(actual, Is.Not.EqualTo(expected));
        }

        [Test]
        public void CorrectSocialNumber(int socialNumber)
        {
            var socialnr = new Program();
            var numberTestStart = socialnr.SocialNumber(000101);
            var numberTestEnd = 160509;
           
            Assert.That(numberTestStart, Is.GreaterThanOrEqualTo(numberTestEnd));
        }
    }
}
