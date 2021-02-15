using System;

namespace Havingfun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var Chas = ($"Charles is a hunk");
            Console.WriteLine(  Chas);

            var ints = new[] { 11, 34, 91, 857, 138, 948596, 918497 };
            for (var idx = 0; idx < 7; idx++) 
            {
                Console.WriteLine($"idx is {idx} and this is its value {ints[idx]}");
            }





        }
    }
}
