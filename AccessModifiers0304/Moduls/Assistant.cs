using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers0304.Moduls
{
    internal class Assistant:Manager
    {
        public void GetFeedBack(Employee employee)
        {
            if (employee.IsSuccessful)
            {
                Console.WriteLine($"{employee.Name},you've been promoted successfully.Get to work!");
            }
            else
            {
                Console.WriteLine($"{employee.Name},promotion unsuccessful.Keep working hard!")
            }
        }
    }
}
