using System;

namespace homework2_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] nbrs =
            {
                756, 233, 509, 792, 700, 596, 833, 658, 998, 742, 187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
                460, 241, 770, 324, 599, 259, 120, 800, 336, 609, 690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
                435, 643, 809, 874, 906, 620, 328, 369, 426, 561
            };

            var highest = 0;
            var lowest = 1000;
            foreach (var nbr in nbrs)
            {
                highest = (nbr > highest) ? nbr : highest;  // more efficent way to do below but may bring 
                lowest = (nbr < lowest) ? nbr : lowest;     // complications(see ternary statement in slides)

                /*
                if (nbr > highest)
                    highest = nbr;  // easiest way we know how to do right now (more clear and better way to do)
                if (nbr < lowest)
                    lowest = nbr;   */
            }
            Console.WriteLine($"highest = {highest} lowest = {lowest}");
        }
    }
}

            /*
            
            var highest = 0;
            var lowest = 1000;
            foreach( var nbr in nbrs)
            {
                if (nbr > highest)
                    highest = nbr;
                if (nbr < lowest)
                    lowest = nbr;
            }
            Console.WriteLine($" highest = {highest} lowest = {lowest}");
        }
    }
}
            
            
            
            
            /*
            var anbr = 1;
            for (var idx = 1; idx <= 30; idx++)
            {
                if (idx % 3 == 0 && idx % 5 == 0)
                {
                    Console.WriteLine($"FIZZBUZZ");
                }
                else
                {
                    if (idx % 3 == 0)
                    {
                        Console.WriteLine($"FIZZ");
                    }
                    else
                    {
                        if (idx % 5 == 0)
                        {
                            Console.WriteLine($"BUZZ");
                        }
                        else
                        {
                            Console.WriteLine($"{idx}");
                        }
                    }
                }
            }
        }
    }
}
            
            
            
          /*  
            
            
            var Anbr = 1;
            for(var idx = 1; idx <= 30; idx++)
            {
                if (idx % 3 == 0 && idx % 5 == 0)
                {
                    Console.WriteLine($"FIZZBUZZ");
                }
                else
                {
                    if (idx % 3 == 0)
                    {
                        Console.WriteLine($"FIZZ");
                    }
                    else
                    {
                        if (idx % 5 == 0)
                        {
                            Console.WriteLine($"BUZZ");
                        }
                        else
                        {
                            Console.WriteLine($"{idx}");
                        }
                    }
                }
            }
        }
    }
}
*/