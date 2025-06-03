using System;

class Program
{
    static void Main()
    {
        int a = 3, b = 4;
        int Sum() => a + b;
        int Product() => a * b;

        var tuple = (Sum: Sum(), Product: Product());

        (int sum, object prod) = tuple;
        Console.WriteLine($"Sum: {sum}, Prod: {prod}");

        object obj = sum;
        if (obj is int x && x > 0)
            Console.WriteLine($"Pattern matched int: {x}");

        switch (prod)
        {
            case int i when i > 10:
                Console.WriteLine($"Product is a large int: {i}");
                break;
            case string s:
                Console.WriteLine($"Product is a string: {s}");
                break;
            default:
                Console.WriteLine("Product is of an unknown type");
                break;
        }
    }
}
