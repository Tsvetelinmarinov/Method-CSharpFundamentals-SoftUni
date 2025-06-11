/**
 * 11.MathOperations
 */

namespace _11.MathOperations;

class Program
{
    static void Main()
    {
        double leftValue = double.Parse(Console.ReadLine()!);
        char action = char.Parse(Console.ReadLine()!);
        double rigthValue = double.Parse(Console.ReadLine()!);
        double result = Calculate(leftSide: leftValue, rigthSide: rigthValue, operation: action);

        Console.WriteLine(result);
    }

    static double Calculate(double leftSide = 666d, double rigthSide = 666d, char operation = '*')
    {
        return operation switch
        {
            '*' => leftSide * rigthSide,
            '/' => leftSide / rigthSide,
            '+' => leftSide + rigthSide,
            '-' => leftSide - rigthSide,
            _ => 6
        };
    }
}