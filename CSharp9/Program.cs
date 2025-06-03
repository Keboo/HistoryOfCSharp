using System;
using CSharp9;

Person p = new("Alice", 30) { Note = "Hello" };

Console.Write($"{p.Name} is ");
Console.WriteLine(p.Age is >= 0 and < 100 ? "Alive" : "Mostly Dead");

namespace CSharp9
{
    record Person(string Name, int Age)
    {
        public string? Note { get; init; }
    }
}