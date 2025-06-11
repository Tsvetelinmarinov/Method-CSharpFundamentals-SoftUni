

using System.Reflection.Metadata.Ecma335;

/**
 * 08.MathPower
 */
namespace _08.MathPower;

class Program
{
    static void Main()
    {
        double baseNumber = double.Parse(Console.ReadLine()!);
        double powerNumber = double.Parse(Console.ReadLine()!);
        double power = GetPower(_base: baseNumber, power: powerNumber);
        Console.WriteLine(power);
    }

    static double GetPower(double _base = 6, double power = 6) 
    {
        double buffer = _base;
        for (int i = 0; i < power - 1; ++i)
        {
            _base *= buffer;
        }

        return _base;
    } 
}