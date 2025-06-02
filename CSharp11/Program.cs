
using System.Numerics;

class ExampleAttribute<T> : Attribute { }

class Program
{
    [Example<int>]
    static void Main()
    {
        string raw = $"""
        This is a raw string!
        It preserves    whitespace and "quotes".
        You can use {DateTime.Now:d} inside it.
        """;
        Console.WriteLine(raw);

        int[] arr = new[] { 1, 2, 3 };
        if (arr is [1, .., 3]) Console.WriteLine("List pattern matched");

        // Required members
        var p = new Person { Name = "Alice" };
        Console.WriteLine(p.Name);

        Console.WriteLine(Add(1, 2));
        Console.WriteLine(Add(1.5, 2.5));

        ReadOnlySpan<byte> utf8 = "Hello"u8;
        Console.WriteLine(System.Text.Encoding.UTF8.GetString(utf8));
    }

    static T Add<T>(T a, T b) where T : INumber<T> => a + b;
}

file class Person {
    public required string Name { get; init; }
}
