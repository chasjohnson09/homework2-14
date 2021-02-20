using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var math = new Math();
            var answer = Math.add(1, 2);
            Console.WriteLine($" 1 plus 2 = {answer}");
            answer = Math.subtract(7, 2);
            Console.WriteLine($" 7 minus 2 = {answer}");
            answer = Math.multiply(7, 2);
            Console.WriteLine($" 7 multiplied by 2 = {answer}");
            answer = Math.divide(8, 2);
            Console.WriteLine($" 8 divided by 2 = {answer}");
            answer = Math.Modulo(7, 2);
            Console.WriteLine($" 7 modulo 2 = {answer}");
            answer = Math.Modulo(13, 5);
            Console.WriteLine($" 13 modulo by 5 = {answer}");
            answer = Math.Modulo(1234, 13);
            Console.WriteLine($" 1234 modulo by 13 = {answer}");
            answer = Math.Power(2, 4);
            Console.WriteLine($" 2 to the 4 power = {answer}");
            answer = Math.Power(7, 4);
            Console.WriteLine($" 7 to the 4 power = {answer}");
            answer = Math.Power(13, 3);
            Console.WriteLine($" 13 to the 3 power = {answer}");
            
            var A = 7;
            bool boolanswer = Math.IsEven(A);
            Console.WriteLine($"{A} is {(boolanswer ? "Even" : "Odd")}");
            
            A = 44;
            boolanswer = Math.IsEven(A);
            Console.WriteLine($"{A} is {(boolanswer ? "Even" : "Odd")}");

            A = 88;
            Console.WriteLine($" {A} incremented is {Math.Incre(A)}");

            Console.WriteLine($" {A} decremented is {Math.Decre(A)}");

            A = Math.Incre(A);  // to increase value inside program without statement

        }
    }
}
