﻿namespace CSharp10;

record struct Point(int X, int Y);
record class Circle(Point Center, double Radius);

class Program
{
    static void Main()
    {
        const string version = "10.0";
        const string greeting = $"Hello from C# {version}";
        Console.WriteLine(greeting);

        Circle circle = new(new Point(1, -2), 5.0);
        if (circle is { Center.X: > 0, Center.Y: < 0 } )
            Console.WriteLine($"Center in quadrant 4: {circle.Center}");
    }
}
