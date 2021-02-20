using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Math
    {
        public static int add(int A, int B)
        {
            return A + B;
        }
        public static int subtract(int A, int B)
        {
            return A - B;
        }
        public static int multiply(int A, int B)
        {
            return A * B;

        }
        public static int divide(int A, int B)
        {
            return A / B;
        }
        public static int Modulo(int A, int B)
        {
            return A - (A / B * B);
        }
        public static int Power(int A, int B)
        {
            var answer = 1;
            for(var idx = 0; idx < B; idx++)
            {
                answer *= A;
            }
            return answer;
        }
        
        
        public static bool IsEven(int A)
        {
            return (Modulo(A, 2) == 0) ? true : false;

        }

        public static int Incre(int A)
        {
            return A + 1;
        }

        public static int Decre(int A)
        {
            return A - 1;
        }
    }
}
