using System;
using CSharp9;

Person p = new("Alice", 30) { Note = "Hello" };

Console.Write($"{p.Name} is ");
Console.WriteLine(p.Age is >= 0 and < 100 ? "Alive" : "Mostly Dead");

// Static anonymous function and lambda discard parameter
Func<int, int, int> add = static (_, y) => y + 1;
int newAge = add(42, p.Age);
Console.WriteLine($"Next year {p.Name}'s age will be: {newAge}");

namespace CSharp9
{
    record Person(string Name, int Age) { public string? Note { get; init; } }
}