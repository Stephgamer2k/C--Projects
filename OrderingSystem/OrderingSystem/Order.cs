using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    abstract class Order
    {
        public int OrderID { get; set; } //Order ID to differentiate each order
        public double Amount { get; set; }

        public Order(int OrderID, double Amount)
        {
            this.OrderID = OrderID;
            this.Amount = Amount;
        }
        public abstract void ProcessPayment(); //ABstract method to be implemented by child classes

        public virtual void PrintRecipt()
        {
            Console.WriteLine($"Order: {OrderID}, Amount: {Amount}");
        }

    }

    class OnlineOrder : Order
    {

        public OnlineOrder(int OrderID, double Amount) : base(OrderID, Amount) 
        {

        }

        public override void ProcessPayment() // 'override' is use to implement the abstract method from the abstract class
        {
            Console.WriteLine($"Processing online payment for: {OrderID}");
        }

        public override void PrintRecipt()
        {
            Console.WriteLine($"Printing recipt for online payment for Order {OrderID}");
            base.PrintRecipt();
        }
    }

    class InPersonOrder : Order 
    {

        public InPersonOrder(int OrderID, double Amount) : base(OrderID, Amount)
        {

        }
        public override void ProcessPayment() // 'override' is use to implement the abstract method from the abstract class
        {
            Console.WriteLine($"Processing store payment for: {OrderID}");
        }
    }
    
}
