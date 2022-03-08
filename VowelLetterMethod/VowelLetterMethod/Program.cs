using System;

namespace VowelLetterMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VowelLetter("zulfiyye"));
        }
        static int VowelLetter(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='a'|| text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
