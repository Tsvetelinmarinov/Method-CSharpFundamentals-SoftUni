/**
 * 05.Orders
 */
namespace _05.Orders;

class Program
{
    static void Main()
    {
        string? product = Console.ReadLine();
        int productQuantity = int.Parse(Console.ReadLine()!);

        CalculatePrice(product: product, count: productQuantity);
    }

    static void CalculatePrice(string? product = "burger", int count = 1, float price = 3.5f)
    {
        price = product switch
        {
            "coffee" => 1.5f,
            "water" => 1f,
            "coke" => 1.4f,
            "snacks" => 2f,
            _ => 0.0f,
        };

        Console.WriteLine($"{price * count:F2}");
    }
}