
using System;
using System.Collections.Generic;

namespace CSharp4
{
    class Program
    {
        private static IEnumerable<Condiment> GetCondiments(string prefix, int count = 2)
        {
            yield return new HorseRadish();
            yield return new Relish();
        }
        
        static void Main(string[] args)
        {
            IEnumerable<Condiment> condiments = GetCondiments(prefix: "v");

            foreach (dynamic thingy in condiments)
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
    }

    class Condiment { }
    class HorseRadish : Condiment { }
    class Relish : Condiment { }
}