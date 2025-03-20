using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Intern : Employee, IReport
    {
        public double InternPay { get; set; }

        public Intern (string name, int id , double internPay):base(name,id)
        {
            if (InternPay < 0 )
            {
                throw new ArgumentException("Intern pay cannot be negative.");
            }
            else
            {
                InternPay = internPay;
            }
        }
        
        public string Report()
        {
            string report;
            Console.WriteLine("Write the Intern report:");
            report = Console.ReadLine();
            return report;
        }

        public void DisplayReport()
        {
            Console.WriteLine($"Report: {Report()}");
        }

        public double CalculatePay()
        {
            return InternPay;
        }
    }
}
