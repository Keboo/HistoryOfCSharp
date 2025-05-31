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

        static async Task DoWorkAsync([CallerMemberName] string caller = null)
        {
            Console.WriteLine("Started in method: {0}", caller);
            await Task.Delay(1000); 
            Console.WriteLine("Async work completed.");
        }
    }
}