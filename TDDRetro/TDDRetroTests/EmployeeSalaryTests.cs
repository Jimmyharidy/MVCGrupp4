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
    public class EmployeeSalaryTests
    {
        [TestMethod()]
        public void SalaryWithProvisionTest()
        {
            Assert.Fail();
        }
        [TestMethod]
        public void SalaryCountFail()
        {
            EmployeeSalary salaryFail = new EmployeeSalary();
            var actual = salaryFail.SalaryWithProvision(10000);
            var expected = 16000;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void SalaryCountCorrect()
        {
            EmployeeSalary salaryCorrect = new EmployeeSalary();
            var actual = salaryCorrect.SalaryWithProvision(100000);
            var expected = 24000;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void SalaryProvisionZero()
        {
            EmployeeSalary salesZero = new EmployeeSalary();
            var actual = salesZero.SalaryWithProvision(0);
            var expected = 15000;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
       
        public void SalaryProvisionNegative()
        {
            EmployeeSalary salesNegative = new EmployeeSalary();
            var actual = salesNegative.SalaryWithProvision(-10000);
            var expected = 14100;
            Assert.AreEqual(actual, expected);
        }
    }
}