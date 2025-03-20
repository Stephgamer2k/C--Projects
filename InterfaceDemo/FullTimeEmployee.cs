using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class FullTimeEmployee : Employee, iPayable
    {
        public int Salary { get; set; }

        public FullTimeEmployee (string name, int id, int salary): base(name,id)
        {
            if(salary < 0)
            {
                throw new ArgumentException("Invalid Salary.");
            }
            else
            {
                Salary = salary;
            }
        }
        public void DisplayInfo ()
        {
            Console.WriteLine($"Employee name: {Name}, ID: {ID}");
            Console.WriteLine($"Monthly salary: {Salary}");
        }
        public double CalculatePay()
        {
            return Salary;
        }

    }
}
