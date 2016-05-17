using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDRetro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDRetro.Tests
{
    [TestClass()]
    public class HourConverterTests
    {
        [TestMethod()]
        public void ConvertHoursTestFail()
        {
            //HourConverter hours = new HourConverter();
            //var actual = hours.ConvertHours("1");
            //var expected = "30";
            //var expected2 = "180";
            //Assert.AreEqual(expected, actual);
            //Assert.AreEqual(expected2, actual);
        }
        [TestMethod]
        public void ConvertHoursTest_Correct()
        {
            HourConverter hours = new HourConverter();
            double input;
            double actualMinutes;
            double actualSeconds;
            hours.ConvertHours(1, out actualMinutes, out actualSeconds);
        }

    }
}