/**
 * 10.MultiplyEvensByOdds
 */

namespace _10.MultiplyEvensByOdds;

class Program
{
    static void Main()
    {
        int input = Math.Abs(int.Parse(Console.ReadLine()!));
        int total = SplitEvents(number: input) * SplitOdss(number: input);
        Console.WriteLine(total);
    }

    static int SplitEvents(int number = 666)
    {
        int sum = default;
        while (number > 0)
        {
            int currentDigit = number % 10;
            number /= 10;
            if (currentDigit % 2 == 0)
            {
                sum += currentDigit;
            }
        }

        return sum;
    }

    static int SplitOdss(int number = 666)
    {
        int sum = default;
        while (number > 0)
        {
            int currentDigit = number % 10;
            number /= 10;
            if (currentDigit % 2 == 1)
            {
                sum += currentDigit;
            }
        }

        return sum;
    }
}