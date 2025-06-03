using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System;

namespace CSharp5
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncMain(args).GetAwaiter().GetResult();
        }
        
        static async Task AsyncMain(string[] args)
        {
            await DoWorkAsync();
        }

        static async Task DoWorkAsync()
        {
            Console.WriteLine("{0} Started in method", DateTime.Now);
            await Task.Delay(1001);
            Console.WriteLine("{0} Async work completed", DateTime.Now);
        }
    }
}