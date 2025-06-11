/**
 * 09.GreaterОfTwoValues
 */

namespace _09.GreaterОfTwoValues;

class Program
{

    static void Main()
    {
        string dataType = Console.ReadLine()!;
        string firstStream = Console.ReadLine()!;
        string secondStream = Console.ReadLine()!;
        string maxValue = GetMaxValue(dataType: dataType, firstValue: firstStream, secondValue: secondStream);

        Console.WriteLine(maxValue);
    }

    static string GetMaxValue(string dataType = "string", string firstValue = "The", string secondValue = "Devil")
    {
        string? result = default;
        switch (dataType)
        {
            case "string":
                result = firstValue.CompareTo(secondValue) == 1 ? firstValue : secondValue;
                break;
            case "int":
                result = int.Parse(firstValue).CompareTo(int.Parse(secondValue)) == 1 ? firstValue : secondValue;
                break;
            case "char":
                result = char.Parse(firstValue).CompareTo(char.Parse(secondValue)) == 1 ? firstValue : secondValue;
                break;
            default:
            return "Error";
        }

        return result;
    }
}