using System.Security.Cryptography.X509Certificates;

namespace DelegateDemo
{
    internal class Program
    {


        //Step 1: Declare the delagate
        public delegate float MathOperation(float a, float b);

        //Step 2: Create method that match the delegate signature
        public static float Add(float a, float b) => a + b;

        public static float Multiply(float a, float b) => a * b;

        public static float Subtract(float a, float b) => a - b;
        public static float Divide(float a, float b) => a / b;
        /*
         * Calculate takes in the delegate to have acces to the methods created from the delegate
         * 
         */
        static void Calculate(MathOperation operation, float input1, float input2)
        {
            Console.WriteLine("Result: " + operation(input1, input2));
        }
        static void Main(string[] args)
        {
            float userInput1;
            float userInput2;

            Console.WriteLine("Enter number 1:");
            userInput1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2:");
            userInput2 = float.Parse(Console.ReadLine());

            //pass mehtod add as a parameter along with the user inputs
            Calculate(Add, userInput1, userInput2);
            Calculate(Multiply, userInput1, userInput2);
            Calculate(Subtract, userInput1, userInput2);
            Calculate(Divide, userInput1, userInput2);

            ////Step 3: Use the delegates
            //MathOperation op = Add; //pointing op to Add method
            //Console.WriteLine("Add:  " + op(userInput1, userInput2));

            //op = Multiply;//pointing op to Multiply method
            //Console.WriteLine("Multiply:  " + op(userInput1, userInput2));



        }
    }
}
