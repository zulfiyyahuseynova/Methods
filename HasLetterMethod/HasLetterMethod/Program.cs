using System;

namespace HasLetterMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasLetter("salam",'a'));
        }
        static bool HasLetter(string text, char word)
        {
            bool characters = false;
            foreach (char letter in text.ToLower())
            {
                if (letter==word)
                {
                    characters = true;
                }
            }
            return characters;
        }
    }
}
