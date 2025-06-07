/**
 * 02. Grades
 */

namespace _02.Grades;

internal class Program
{

    static void Main()
    {

        //Create a method that receives a grade between 2.00 and 6.00 and prints the
        // corresponding grade definition:
        //•	2.00 – 2.99 - "Fail"
        //•	3.00 – 3.49 - "Poor"
        //•	3.50 – 4.49 - "Good"
        //•	4.50 – 5.49 - "Very good"
        //•	5.50 – 6.00 - "Excellent"

        float inputGrade = float.Parse(Console.ReadLine() ?? "666f");
        Console.WriteLine(GenerateAssessment(inputGrade));

    }

    /// <summary>
    /// Generates a string representations of a grade
    /// </summary>
    /// <param name="grade">The grade(integer) to be converted</param>
    /// <returns></returns>
    static string GenerateAssessment(float grade = 6f)
    {
        string? assessment = default;
        if (grade >= 2 && grade <= 2.99)
        {
            assessment = "Fail";
        }
        else if (grade >= 3 && grade <= 3.49)
        {
            assessment = "Poor";
        }
        else if (grade >= 3.5 && grade <= 4.49)
        {
            assessment = "Good";
        }
        else if (grade >= 4.5 && grade <= 5.49)
        {
            assessment = "Very good";
        }
        else if (grade >= 5.5 && grade <= 6)
        {
            assessment = "Excellent";
        }
        else
        {
            assessment = "Error";
        }

        return assessment;
    }

}