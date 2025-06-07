/**
 * 01.SignOfIntegerNumbers
 */

using System;

namespace _01.SignOfIntegerNumbers;

internal class Program
{

    static void Main()
    {

        /**
         * A single integer is given, create a method that checks if the given number is positive, 
         *  negative, or zero. As a result print:
         *  
         *  •	For positive number: "The number {number} is positive. "
         *  •	For negative number: "The number {number} is negative. "
         *  •	For zero number: "The number {number} is zero. "
         *
         */

        int inputStream = int.Parse(Console.ReadLine() ?? "666");
        CheckNumberStatus(number: inputStream);

    }

    /// <summary>
    ///  Checks if the number is positive, negative or zero and prints the result
    /// </summary>
    /// <param name="number">The number to be checked</param>
    static void CheckNumberStatus(int number = 666)
    {

        string? status = default;
        if (number == 0)
        {
            status = $"The number {number} is zero.";
        }
        else if (number < 0)
        {
            status = $"The number {number} is negative.";
        }
        else if (number > 0)
        {
            status = $"The number {number} is positive.";
        }
        else
        {
            status = $"Error";
        }

        Console.WriteLine(status);

    }

}