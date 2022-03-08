using System;

namespace NumLengthMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumLength(-362));
        }

        static int NumLength(int num)
        {
            int count = 0;
            while (num > 9 || num < -9)
            {
                num /= 10;
                count++;
            }
            count += 1;
            return count;
        }
    }
}
