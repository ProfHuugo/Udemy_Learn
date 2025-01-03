using System;
using System.Globalization;

namespace Course
{
    class Employee 
    {

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Salary { get; set; }


        public void increaseSalary( double percentage) {
            Salary += Salary * percentage / 100;
        }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }


        public override string ToString()
        {
            return Id
            + ", "
            + Name
            + ", "
            + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}