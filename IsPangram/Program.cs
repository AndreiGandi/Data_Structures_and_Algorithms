using System;
using System.Collections.Generic;

namespace IsPangram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(IsPangram("The quick brown fox jumps over the lazy dog")); //true
        }
        static bool IsPangram(string text)
        {
            List<char> letters = new List<char>();
            foreach(var item in text.ToLower())
            {
                if(Char.IsLetter(item) && !letters.Contains(item))
                {
                    letters.Add(item);
                }
            }
            if (letters.Count == 26)
                return true;
            return false;
        }
    }
}
