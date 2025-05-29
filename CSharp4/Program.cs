
using System;
using System.Collections.Generic;

namespace CSharp4
{

    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Condiment> condiments = GetCondiments();
            IEnumerable<object> objects = condiments;

            foreach (dynamic thingy in objects)
            {
                Print(thingy);
            }
        }
        
        private static void Print(HorseRadish horseRadish)
        {
            Console.WriteLine("Horse Radish");
        }

        private static void Print(Relish relish)
        {
            Console.WriteLine("Relish");
        }

        private static IEnumerable<Condiment> GetCondiments()
        {
            yield return new HorseRadish();
            yield return new Relish();
        }
    }

    class Condiment { }
    class HorseRadish : Condiment { }
    class Relish : Condiment { }
}