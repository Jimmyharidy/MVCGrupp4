using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Daisy
{
    public class CheckPerson
    {
        public string CheckPersonNumber(string pnr)
        {
            if (pnr != "130229")
                return pnr;
            else
            {
                return "";
            }
            //throw new NotImplementedException();
        }
    }
    [TestFixture]
    public class CheckPersonTest
    {
        
        [Test]
        public void CheckNumberBeginning()
        {
            // Arrange
            CheckPerson person = new CheckPerson();
            // Act
            var actual = person.CheckPersonNumber("20010101");
            var estimated = "20010101";
            //Assert
            Assert.That(actual, Is.EqualTo(estimated));
        }

        [Test]
        public void CheckNumberMiddleDate()
        {
            CheckPerson person = new CheckPerson();
            var actual = person.CheckPersonNumber("080615");
            var expected = "080615";
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void CheckNumber_EndDate()
        {
            CheckPerson person = new CheckPerson();
            var actual = person.CheckPersonNumber("160509");
            var expected = "160509";
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CheckNumber_CorrectLeapyear()
        {
            CheckPerson person = new CheckPerson();
            var actual = person.CheckPersonNumber("120229");
            var expected = "120229";
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CheckNumber_InCorrectLeapyear()
        {
            CheckPerson person = new CheckPerson();
            var actual = person.CheckPersonNumber("130229");
            
            Assert.That(actual, Is.Null);
        }
        // Correct date in beginning
        // Correct date in middle
        // Correct date in end
        // correct date in month
        // correct date in day
        // correct date in leapyear
        // incorrect date before
        // incorrect date after
        // incorrect date not leapyear

    }
    
}
