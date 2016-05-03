using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Employee.Models
{
    public class EmployeeContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Salary> Salaries { get; set; }

        public EmployeeContext(): base("EmployeeSalary")
        {
            Database.SetInitializer<EmployeeContext>(new EmployeeInitializer());
        }
    }

    public class EmployeeInitializer : DropCreateDatabaseAlways<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var employees = new List<Employee>()
            {
                new Employee() {EmployeeId = 1, Name = "Adriana", Phone = "0708158589", Title = "System account Manager"},
                new Employee() {EmployeeId = 2, Name = "Kalle", Phone = "1235848", Title = "Garbage collector"},
                new Employee() {EmployeeId = 3, Name = "Johan", Phone = "123456789", Title = "It engineer"},
            };
            foreach (var employee in employees)
                context.Employees.Add(employee);

            var salaries = new List<Salary>()
            {
                new Salary() {SalaryId = 1, Date = DateTime.Today, HoursOfPeriod = 160, MoneyOut = 15000, WorkedHours = 80},
                new Salary() {SalaryId = 2, Date = DateTime.Today, HoursOfPeriod = 140, MoneyOut = 25000, WorkedHours = 70},
                new Salary() {SalaryId = 3, Date = DateTime.Today, HoursOfPeriod = 120, MoneyOut = 2000, WorkedHours = 15},
            };
            foreach (var salary in salaries)
                context.Salaries.Add(salary);
            context.SaveChanges();
        }
    }
}