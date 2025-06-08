/**
 * 06.CalculateRectangleArea
 */

namespace _06.CalculateRectangleArea;

class Program
{
    static void Main()
    {
        int sideA = int.Parse(Console.ReadLine()!);
        int sideB = int.Parse(Console.ReadLine()!);
        double area = GetArea(a: sideA, b: sideB);
        Console.WriteLine(area);
    }

    static double GetArea(int a = 6, int b = 6)
    {
        return a * b;
    }
}