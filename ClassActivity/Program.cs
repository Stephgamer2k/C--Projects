namespace ClassActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***Queues***
             * Queues make use of the FIFO princilpe (first in first out)
             * First element added is the element to be removed from the list
             * WIll used in scenarios where importance is given to the person who arrived first
            *Syntax: Queue<type> name = new Queue<type>();

            ***Stacks***
             * Stacks make use of the LIFO principle (last in first out)
             * If a mistake is made, the last processed ticket can be restored using a stack(LIFO)
             * Syntax: Stack<type> name = new Stack<type>();
             */

            Queue<string> ticketQueue = new Queue<string>();

            Stack<string> undoTicketStack = new Stack<string>();

            //Add ticket to the queue (FIFO)
            ticketQueue.Enqueue("Ticket #001: Customer Support");
            ticketQueue.Enqueue("Ticket #002: Billing Inquiry");
            ticketQueue.Enqueue("Ticket #003: Technical issues");

            //Display all the tickets
            foreach(var ticket in ticketQueue)
            {
                Console.WriteLine(ticket);
            }
            Console.WriteLine();

            //Peek(); shows the first element of the queue. helps see the first ticket to attend to
            Console.WriteLine("Next ticket to be processed " + ticketQueue.Peek());

            Console.WriteLine("\nProcessing the next ticket...\n");
            string processedTicket = ticketQueue.Dequeue();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Processed: {processedTicket}");
            Console.ResetColor();

            Console.WriteLine("Next ticket to be processed " + ticketQueue.Peek());

            Console.WriteLine("Would you like to undo the removal?Y/N");
            string choice = Console.ReadLine();

            if(choice.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                undoTicketStack.Push(processedTicket);
                string restoredTicket = undoTicketStack.Pop();
                ticketQueue.Enqueue(restoredTicket);
                foreach (var ticket in ticketQueue)
                {
                    Console.WriteLine(ticket);
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ticket successfully added to the Queue");
                Console.ResetColor();
                Console.WriteLine("Thank you for using the ticketing system");
            }
            else
            {
                Console.WriteLine("Thank you for using the ticketing system");
            }
        }
    }
}
