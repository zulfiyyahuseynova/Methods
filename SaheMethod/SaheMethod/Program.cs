using System;

namespace SaheMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sahe(1,2,3,5,"ucbucagin daxiline cekilmis cevre"));
        }

        static int Sahe(int radius, string figure)
        {
            int result = 0;
            if (figure=="cevre")
            {
                 result = radius * radius * 3;
            }
            return result;
        }
        static int Sahe(int a, int b, string figure)
        {
            int result = 0;
            if (figure=="duzbucaqli")
            {
               result = a * b;
            }
            return result;
        }
        static int Sahe(int a, int b, int c, string figure)
        {
            int result = 0;
            if (figure=="duzbucaqli paralelpiped")
            {
                result = 2 * (a * b + b * c + a * c);
            }
            return result;
        }
        static int Sahe(int a, int b, int c, int radius, string figure)
        {
            int p = (a + b + c) / 2;
            int result = 0;
            if (figure=="ucbucagin daxiline cekilmis cevre")
            {
                result = p * radius;
            }
            return result;
        }
    }
}
