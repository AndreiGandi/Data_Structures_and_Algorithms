using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsIsogram("isogram")); //true
            Console.WriteLine(IsIsogram("isograms")); //false
            Console.WriteLine(IsIsogram("subdermatoglyphic")); //true
            Console.WriteLine(IsIsogram("Alphabet")); //false
            Console.WriteLine(IsIsogram("alphAbet")); //false
            Console.WriteLine(IsIsogram("thumbscrew-japingly")); //true
            Console.WriteLine(IsIsogram("ix-year-old")); //true
            Console.WriteLine(IsIsogram("Emily Jung Schwartzkopf")); //true
        }

        //using Collections
        //public static bool IsIsogram(string word)
        //{
        //    List<char> letters = new List<char>();
        //    foreach (var ch in word.ToLower())
        //    {
        //        if (char.IsLetter(ch))
        //        {
        //            if (!letters.Contains(ch))
        //            {
        //                letters.Add(ch);
        //            }
        //            else return false;
        //        }
        //    }
        //    return true;
        //}

        public static bool IsIsogram(string word)
        {
            word = word.ToLower(); // Avoid word with duplicated character in mixed case
            bool isIsogram = true;
            for(int i = 0; i<word.Length-1; i++)
            {
                if (!Char.IsPunctuation(word[i]) && !char.IsSymbol(word[i]) && !char.IsWhiteSpace(word[i]))
                {
                    for(int j = i+1; j<=word.Length-1; j++)
                    {
                        if (word[i] == word[j])
                            isIsogram = false;
                    }
                }
            }



            return isIsogram;
        }
    }
}
