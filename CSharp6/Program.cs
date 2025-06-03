using static System.Console;

namespace CSharp6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person p = null;
            WriteLine($"Name: {p?.Name ?? "No name"}");

            p = new Person() { Name = "Alice", Age = 30 };
            WriteLine($"Person: {p}");
        }
    }
    class Person
    {
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; } = 0;

        public override string ToString() => $"{Name}, {nameof(Age)}: {Age}";
    }
}