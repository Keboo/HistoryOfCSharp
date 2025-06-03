class Program
{
    static void Main()
    {
        int[] numbers = [1, 2, 3];
        Console.WriteLine($"Collection: {string.Join(", ", numbers)}");

        var p = new Point(7, 8);
        Console.WriteLine($"Point: {p.X}, {p.Y}");
    }
}

class Point(int x, int y)
{
    public int X { get; } = x;
    public int Y { get; } = y;
}
