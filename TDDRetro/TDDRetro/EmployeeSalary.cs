using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDRetro
{
    public class EmployeeSalary
    {
        public double SalaryWithProvision(double provision)
        {
            const double provisionProcent = 0.09;
            const double mainSalary = 15000;

            var saleprovision = provision * provisionProcent;
            var salary = mainSalary + saleprovision;
            return salary;

        }
    }
}
