/**
 * 04.PrintingTriangle
 */

namespace _04.PrintingTriangle;

internal class Program
{
    static void Main()
    {
        int begining = int.Parse(Console.ReadLine()!);
        int end = int.Parse(Console.ReadLine()!);
        PrintTriangle(begining, end);
    }
    
    static void PrintLine(int start = 1, int end = 6)
    {
        for (int i = start; i <= end; ++i)
        {        
            Console.Write($"{i} ");
        }

        Console.WriteLine();
    }

    static void PrintTriangle(int start = 1, int end = 6)
    {
        for (int i = start; i <= end; ++i)
        {
            PrintLine(start, i);
        }

        for (int i = end - 1; i >= start; --i)
        {
            PrintLine(start, i);
        }
    }
}