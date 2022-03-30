using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_03_2022_Classwork_Again.Models
{
    internal class Employee : Person
    {
        private int _salaryOfHour;
        private int _workingHour;
        public Employee(string name, string surname, int age,int salaryOfHour, int workingHour)
        {
            Name = name;
            Surname = surname;
            if (age >= 18) Age = age;
            SalaryOfHour = salaryOfHour;
            WorkingHour = workingHour;
        }
        public int SalaryOfHour
        {
            get { return _salaryOfHour; }
            set
            {
                if (value > 0) _salaryOfHour = value;
            }
        }
        public int WorkingHour
        {
            get { return _workingHour; }
            set
            {
                if (value > 0 && value <= 240) _workingHour = value;
            }
        }
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override int Age { get; set; }

        public int CalculateSalary()
        {
            return WorkingHour * SalaryOfHour;
        }

        public override void GetInfo()
        {
            if (CalculateSalary() >= 250) Console.WriteLine($"Name - {Name}\nSurname - {Surname}\nAge - {Age}\nSalary Per Hour - {SalaryOfHour}\nWorking Hour - {WorkingHour}\nEmployee's Monthly Salar is {CalculateSalary()}");
            else Console.WriteLine($"Name - {Name}\nSurname - {Surname}\nAge - {Age}\nSalary Per Hour - {SalaryOfHour}\nWorking Hour - {WorkingHour}\nMonthly salary cannot be less than 250!");
        }
    }
}
