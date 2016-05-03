using System;

namespace EmployeeProject.Models
{
    public class Salary
    {
        public int SalaryId { get; set; }
        public DateTime Date { get; set; }
        public int WorkedHours { get; set; }
        public int HoursOfPeriod { get; set; }
        public int MoneyOut { get; set; }
    }
}