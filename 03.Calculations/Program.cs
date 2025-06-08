/**
 * 03.Calculations
 */

namespace _03.Calculations
{

    internal class Program
    {

        static void Main()
        {

            //input => add, subtract, multiply, divide
            string operation = Console.ReadLine() ?? "add";
            int leftNumber = int.Parse(Console.ReadLine()!);
            int rigthNumber = int.Parse(Console.ReadLine()!);

            switch (operation)
            {
                case "add":
                    Add(a: leftNumber, b:rigthNumber);
                    break;
                case "subtract":
                    Subtract(a: leftNumber, b: rigthNumber);
                    break;
                case "muliply":
                    Multiply(a: leftNumber, b: rigthNumber);
                    break;
                case "divide":
                    Divide(a: leftNumber, b: rigthNumber);
                    break;
                default:
                    Console.WriteLine($"The operator {operation} is not valid!");
                break;
            }

        }

        /// <summary>
        /// Sum two numbers and prints the sum
        /// </summary>
        /// <param name="operation"></param>
        static void Add(int a = 666, int b = 666) =>  Console.WriteLine(a + b);

        /// <summary>
        /// Subtracts one number from another and prints the difference
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Subtract(int a = 666, int b = 666) => Console.WriteLine(a - b);

        /// <summary>
        /// Multuply two numbers and prints the result
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Multiply(int a = 666, int b = 666) => Console.WriteLine(a * b);

        /// <summary>
        /// Divide two numbers and prints the result
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Divide(int a = 666, int b = 666) => Console.WriteLine(a / b);
        
    }

}