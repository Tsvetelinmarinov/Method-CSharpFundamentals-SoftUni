/**
 * 07.RepeatString
 */

namespace _07.RepeatString;

class Program
{
    static void Main()
    {
        string inputStream = Console.ReadLine() ?? "6";
        int count = int.Parse(Console.ReadLine() ?? "6");
        string fullString = Repeat(text: inputStream, count: count);

        Console.WriteLine(fullString);
    }

    static string Repeat(string text, int count = 6)
    {
        string repeated = default!; 
        for (int i = 0; i < count; i++)
        {
            repeated = String.Concat(text, repeated);
        }

        return repeated;
    }
}