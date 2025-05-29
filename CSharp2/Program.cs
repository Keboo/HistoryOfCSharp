using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp2
{
    partial class Program
    {
        private static void SumNumbers()
        {
            List<int?> numberList = new List<int?>();
            numberList.Add(1);
            numberList.Add(null);
            numberList.Add(2);
            numberList.Add(3);
            
            Sum(numberList);
        }

        private static void Sum(IEnumerable<int?> numbers)
        {
            int sum = 0;
            foreach (int? number in numbers)
            {
                sum += number ?? 0; ;
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
