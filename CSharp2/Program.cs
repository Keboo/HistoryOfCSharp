using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            List<int?> numberList = new List<int?>();
            foreach (int? number in GetNumbers())
            {
                numberList.Add(number ?? 0);
            }

            Console.WriteLine("Numbers: {0}", string.Join(",", numberList));
        }
    }
}
