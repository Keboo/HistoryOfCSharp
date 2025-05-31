using static System.Console;

namespace CSharp6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // String interpolation, null propagator, static import
            Person p = null;
            WriteLine($"Person's name: {p?.Name ?? "No person"}");

            p = new Person(age: 30) { Name = "Alice" };
            WriteLine($"Person info: {p}");

            // nameof operator
            WriteLine($"Property name: {nameof(Person.Name)}");

            try
            {
                new Person(-1);
            }
            catch (System.Exception ex) when (ex.Message.Contains("negative"))
            {
                WriteLine($"Caught exception with filter: {ex.Message}");
            }
        }

    }
    class Person
    {
        public string Name { get; set; } = "Unknown";
        public int? Age { get; set; } = 0;

        public Person(int? age)
        { 
            Age = ValidateAge(age ?? 0);
        }

        static int ValidateAge(int value)
        {
            if (value < 0)
            {
                throw new System.ArgumentException("Value cannot be negative");
            }
            return value;
        }
        public override string ToString() => $"{Name}, Age: {Age?.ToString() ?? "N/A"}";
    }
}