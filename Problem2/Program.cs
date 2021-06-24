using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = Fibonacci().TakeWhile(x => x < 4000000L)
                          .Where(x => x % 2L == 0L)
                          .Sum();

            Console.WriteLine(x);
        }

        public static IEnumerable<long> Fibonacci()
        {
            long current = 0;
            long next = 1;
            while (true)
            {
                yield return current;
                long temp = next;
                next = current + next;
                current = temp;
            }
        }

    }
}
