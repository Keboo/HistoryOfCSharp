using System;

class Program
{
    static void Main()
    {
        (int sum, object prod) = Calc(3, 4, out int diff);
        Console.WriteLine($"Sum: {sum}, Prod: {prod}, Diff: {diff}");

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

        CreateDemo();

        Literals();
    }

    static (int Sum, object Product) Calc(int a, int b, out int diff)
    {
        diff = a - b;
        int Sum() => a + b;
        int Product() => a * b;
        return (Sum(), Product());
    }

    static void CreateDemo()
    {
        try { var d = new Demo(-1); } catch (Exception ex) { Console.WriteLine(ex.Message); }
    }

    static void Literals()
    {
        int bin = 0b0110_1011;
        int big = 1_000_000;
        Console.WriteLine($"Binary: 0x{bin:X}, Big: {big:N0}");
    }
}

class Demo
{
    private int _value;
    public int Value
    {
        get => _value;
        set => _value = value < 0 ? throw new ArgumentException("Value must be non-negative") : value;
    }

    public Demo(int value) => Value = value;
    ~Demo() => Console.WriteLine($"Destructor called for value: {_value}");
}
