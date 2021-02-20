using System;

namespace class2_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); 

            // find the sum of all the numbers that are divisable by 7 from 1-70 
            var sum = 0;

            for (var idx = 1; idx <= 70; idx++)
            {
                if (idx % 7 == 0)
                {
                    sum += idx;
                }

            }
            Console.WriteLine($" the sum is {sum}");    // always print outside the loop
        }
    }
}
