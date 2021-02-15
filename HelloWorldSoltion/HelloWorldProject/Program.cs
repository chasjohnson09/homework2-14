using System;

namespace HelloWorldProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World In C#!");
            Console.WriteLine("C# by Chas Johnson");
            var Counter = 0;
            Console.WriteLine(Counter);
            Counter = Counter + 13;
            Console.WriteLine(Counter);
            Counter = Counter - 3;
            Console.WriteLine(Counter);
            Counter = Counter * 5;
            Console.WriteLine(Counter);
            Counter = Counter/ 7;
            Console.WriteLine(Counter);


            var numerator = 10.0;
            var denominator = 3.0;
            var answer = numerator / denominator;
            Console.WriteLine(answer);

            var modulo = 10 % 3;
            Console.WriteLine(modulo);

            var firstname = "Chas";
            var lastname = "Johnson";
            var fullname = firstname + " " + lastname;
            Console.WriteLine(fullname);
            fullname = $"{firstname} {lastname}";
            Console.WriteLine(fullname);
            fullname = fullname.ToUpper();
            Console.WriteLine(fullname);

            var biggerscopevariable = 77;

            {
                var scopeViariable = 1;
                Console.WriteLine(scopeViariable);
            }

            biggerscopevariable = biggerscopevariable + 1;
            //scopevariable = scopevariable + 1;

            int? nullableIntegar = null;
            // int nonnullableIntegar = null;


            bool OneEqualsOne = true;
            bool Thisisfalse = !OneEqualsOne;

            int[] AssesmentScores = new int[2];
            AssesmentScores[0] = 120;
            AssesmentScores[1] = 95;
            Console.WriteLine($"Index 0 is {AssesmentScores[0]} and index 1 is {AssesmentScores[1]}");

            var Languages = new string[5];
            Languages[0] = ($" Git/Github");
            Languages[1] = ($" Sql");
            Languages[2] = ($" C#");
            Languages[3] = ($" Javascript");
            Languages[4] = ($" Angular");

            Console.WriteLine(Languages);

           

        }
    }
}
