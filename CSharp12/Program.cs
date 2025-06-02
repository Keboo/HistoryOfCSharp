using System;
using System.Runtime.CompilerServices;

using PointX = (int X, int Y);

class Program
{
    static void Main()
    {
        int[] numbers = [1, 2, 3];
        Console.WriteLine($"Collection: {string.Join(", ", numbers)}");

        var p = new Point(7, 8);
        Console.WriteLine($"Point: {p.X}, {p.Y}");

        var f = (int x, int amount = 1) => x + amount;
        Console.WriteLine($"Lambda default: {f(42)}");
        Console.WriteLine($"Lambda with arg: {f(42, 5)}");

        // Alias any type usage
        PointX pointX = (99, 100);
        Console.WriteLine($"Alias type: {pointX.X}, {pointX.Y}");
    }
}

class Point(int x, int y)
{
    public int X { get; } = x;
    public int Y { get; } = y;
}
