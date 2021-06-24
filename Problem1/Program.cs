using System;
using System.Linq;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Enumerable.Range(1, 1000).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
            Console.WriteLine(x);
        }
    }
}
