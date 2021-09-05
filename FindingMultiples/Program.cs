using System;

namespace FindingMultiples
{
    class Program
    {
        // Routine to find numbers that are multiple of 3 and multiple of 5
        // using Function delegates.
        // An elegant way to go around the horrible syntax: If then ElseIf
        // or worse, nested ifs...
        //
        static void Main(string[] args)
        {
            Func<int, bool> m3 = x => x % 3 == 0;
            Func<int, bool> m5 = x => x % 5 == 0;

            for (int i = 1; i <= 100; i++)
            {
                // Multiple of 3 and 5
                if (m3(i) == true && m5(i) == true)
                {
                    Console.WriteLine("{0} - BossHog", i);
                    continue;
                }

                // Multiple of 3
                if (m3(i) == true)
                {
                    Console.WriteLine("{0} - Boss", i);
                    continue;
                }

                // Multiple of 5
                if (m5(i) == true)
                {
                    Console.WriteLine("{0} - Hog", i);
                    continue;
                }

                Console.WriteLine("{0} -  {1}  ", i, i);
            }
        }
    }
}
