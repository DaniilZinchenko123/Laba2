using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeController
{
    public class Employee
    {
        private string lastName;
        private string firstName;

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public string LastName
        {
            get { return lastName; }
        }

        public string FirstName
        {
            get { return firstName; }
        }

        public double CalculateSalary(string position, int experience)
        {
            double baseSalary = 0;
            switch (position)
            {
                case "Менеджер":
                    baseSalary = 20000;
                    break;
                case "Розробник":
                    baseSalary = 40000;
                    break;
                case "Тестувальник":
                    baseSalary = 25000;
                    break;
                default:
                    Console.WriteLine("Невідома посада");
                    break;
            }
            double experienceBonus = experience * 1000;
            double salary = baseSalary + experienceBonus;
            return salary;
        }

        public double CalculateTax(double salary)
        {
            double taxRate = 0.18; 
            return salary * taxRate;
        }
        public string GetEmployeeInfo(string Position, int Experience)
        {
            return $"Прізвище: {LastName}\nІм'я: {FirstName}\nПосада: {Position}\nСтаж: {Experience} років";
        }
    }
}
