class Program
{
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

        var p = new Person { Name = "Alice" };
        Console.WriteLine(p.Name);
    }
}

file class Person {
    public required string Name { get; init; }
}
