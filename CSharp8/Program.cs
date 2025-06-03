using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

namespace CSharp8
{
    class Program
    {
        static async Task Main()
        {
            string? message = null;
            message ??= "Hello, C# 8!";
            Console.WriteLine(message);

            // Indices and ranges
            int[] numbers = { 1, 2, 3, 4, 5 };
            int last = numbers[^1]; // ^1 is the last element
            int[] middle = numbers[1..^1]; // from index 1 to last-1
            Console.WriteLine($"Last: {last}, Middle: {string.Join(",", middle)}");

            IAsyncEnumerable<IShape?> shapes = GetShapesAsync();
            await foreach (IShape? shape in shapes)
            {
                if (shape is { Edges: 0 })
                {
                    Console.Write($"o_O ");
                }

                Console.Write(shape switch
                {
                    null => "Shape is null",
                    Rectangle r => $"Rectangle: {r.Width}x{r.Height}",
                    Circle c => $"Circle: Radius {c.Radius}",
                    _ => "Unknown shape"
                });

                Console.WriteLine(shape?.Suffix() ?? "");
            }

            static async IAsyncEnumerable<IShape?> GetShapesAsync()
            {
                await Task.Yield();

                yield return null;
                yield return new Rectangle(5, 10);
                yield return new Circle(3);

            }
        }
    }
    class Rectangle : IShape
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Width { get; }
        public int Height { get; }
        public int Edges => 4;

    }
    class Circle : IShape
    {
        public Circle(int radius) => Radius = radius;
        public int Radius { get; }
        public int Edges => 0;

        public string? Suffix() => " round";
    }
    interface IShape
    {
        int Edges { get; }

        string? Suffix() => null;
    }
}
