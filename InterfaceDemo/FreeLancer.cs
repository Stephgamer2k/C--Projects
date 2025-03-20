using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class FreeLancer : Employee, iPayable
    {
        public double RatePerProject { get; set; }
        public int ProjectsCompleted { get; set; }
         
        public FreeLancer (string name, int id, double ratePerProject, int projectsCompleted): base(name,id)
        {
            if(RatePerProject < 0 || ProjectsCompleted < 0)
            {
                throw new ArgumentException("Rate per project or Projects Completed connot be negative.");
            }
            else
            {
                RatePerProject = ratePerProject;
                ProjectsCompleted = projectsCompleted;
            }

        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Employee name: {Name}, ID: {ID}");
            Console.WriteLine($"Rate: {RatePerProject}, Projects Completed: {ProjectsCompleted}");
        }
        public double CalculatePay()
        {
            return RatePerProject * ProjectsCompleted;
        }
    }
}
