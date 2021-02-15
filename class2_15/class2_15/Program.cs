using System;

namespace class2_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var sum = 0;
            for (var idx = 1; idx <= 70; idx++)
            {
                if (idx % 7 == 0)
                {
                    sum += idx;
                }

            }
            Console.WriteLine($" the sum is {sum}");
        }
    }
}
