using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers0304.Moduls
{
    internal class Manager
    {
        public void GetPromotion(Employee employee)
        {
            employee.Salary += 100;
            employee.IsSuccessful = true;
            Console.WriteLine($"{employee.Name} has been promoted successfully!");
        }
    }
}
