namespace OrderingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ordering system the processes online and in store payments
            Order onlineOrder = new OnlineOrder { Amount = 10, OrderID = 01 }; //parsing the values for OrderID and Amount
            onlineOrder.ProcessPayment();
            onlineOrder.PrintRecipt();

            Order inStoreOrder = new InPersonOrder { Amount = 1000, OrderID = 01 }; //parsing the values for OrderID and Amount
            inStoreOrder.ProcessPayment();
            inStoreOrder.PrintRecipt(); //PrintRecipt(); method was not implemented in the InPersonOrder class
                                        //However this class inherites the method from the parent cless
        }
    }
}
