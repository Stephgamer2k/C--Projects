using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Consultant: IReport
    {
        public double RatePerHour { get; set; }
        public int HoursWorked { get; set; }

        public Consultant(double ratePerHour, int hoursWorked) 
        {
           if(ratePerHour < 0)
            {
                throw new ArgumentException("Hourly rate cannot be negative");
            }
            else
            {
                RatePerHour = ratePerHour;
                HoursWorked = hoursWorked;

            }
               
        }

        
        public string Report()
        {
            string report;
            Console.WriteLine("Write the Consultant report:");
            report = Console.ReadLine();
            return report;
        }

        public void DisplayReport()
        {
            Console.WriteLine($"Report: {Report()}");
        }

        public double CalculatePay()
        {
            return RatePerHour * HoursWorked;
        }
    }
}
