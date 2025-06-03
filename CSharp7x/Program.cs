using System;
using System.Threading.Tasks;

namespace CSharp7x
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // 7.1
            await Task.Yield();

            string stringLiteral = default;
            Console.WriteLine($"Default literal: '{stringLiteral ?? "null"}'");

            // 7.2
            new Derived().CallShow();

            // 7.3
            var t1 = (1, 2);
            var t2 = (1, 2);
            Console.WriteLine($"Tuples equal: {t1 == t2}");

            ShowEnumValue(DayOfWeek.Monday);
            void ShowEnumValue<T>(T e) where T : Enum
            {
                Console.WriteLine($"Enum value: {e}");
            }
        }

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

