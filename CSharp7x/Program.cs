using System;
using System.Threading.Tasks;

namespace CSharp7x
{
    class Program
    {
        // Async Main (C# 7.1)
        static async Task Main(string[] args)
        {
            await Task.Yield();

            string stringLiteral = default;
            Console.WriteLine($"Default literal: '{stringLiteral ?? "null"}'");

            int age = 42;
            var person = (name: "Alice", age);
            Console.WriteLine($"Tuple: {person.name}, {person.age}");

            PrintType(123);
            PrintType("abc");
            void PrintType<T>(T value)
            {
                if (value is int i)
                    Console.WriteLine($"int: {i}");
                else if (value is string s)
                    Console.WriteLine($"string: {s}");
            }

            Print(x: 2, 1);
            void Print(int x, int y) => Console.WriteLine($"x={x}, y={y}");

            var t1 = (1, 2);
            var t2 = (1, 2);
            Console.WriteLine($"Tuples equal: {t1 == t2}");

            int bin = 0b_0110_1011;
            int hex = 0x_B2_3F;
            Console.WriteLine($"Binary: {bin}, Hex: {hex:X}");

            ShowEnumValue(DayOfWeek.Monday);
            void ShowEnumValue<T>(T e) where T : Enum
            {
                Console.WriteLine($"Enum value: {e}");
            }

            // private protected
            new Derived().CallShow();

        }

        // Demonstrates private protected
        class Base
        {
            private protected void Show() => Console.WriteLine("private protected method");
        }

        class Derived : Base
        {
            public void CallShow() => Show();
        }
    }
}

