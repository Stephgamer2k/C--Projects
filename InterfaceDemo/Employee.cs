using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
   abstract class Employee
    {
        //Employee class attributes. With getters and setters
        public string Name { get; set; }

        public int ID { get; set; }

        //Constructor for Employee class
        public Employee(string name, int id)
        {
            Name = name;
            ID = id;
        }

        //Concrete method. Automatically inherited by child classes
        public void DisplayInfo()
        {
            Console.WriteLine($"Employee: {Name}, ID: {ID}");
        }
        //abstract method 
        //public abstract double CalculatePay();
    }




}
