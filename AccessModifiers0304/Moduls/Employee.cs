using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers0304.Moduls
{
    internal class Employee
    {
        public string Name { get; set; }
        public bool IsSuccessful { get; set; }
        public double Salary { get; set; }
        public Employee(string name,double salary)
        {
            Name = name;
            Salary = salary;
            IsSuccessful = false;
        }
      

    }
}
