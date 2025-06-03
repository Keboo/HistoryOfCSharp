
using System.Collections.Generic;

namespace CSharp2
{
    partial class Program
    {
        private static IEnumerable<int?> GetNumbers()
        {
            yield return 1;
            yield return null;
            yield return 2;
            yield return 3;
        }
    }
}