using System;
using System.Text;

namespace Acronym
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Abbreviate("Portable Network Graphics")); //PNG
            Console.WriteLine(Abbreviate("Ruby on Rails")); //ROR
            Console.WriteLine(Abbreviate("First In, First Out")); //FIFO
            Console.WriteLine(Abbreviate("GNU Image Manipulation Program")); //GIMP
            Console.WriteLine(Abbreviate("Complementary metal-oxide semiconductor"));//CMOS
            Console.WriteLine(Abbreviate("Rolling On The Floor Laughing So Hard That My Dogs Came Over And Licked Me")); // ROTFLSHTMDCOALM
            Console.WriteLine(Abbreviate("Something - I made up from thin air")); //SIMUFTA
            Console.WriteLine(Abbreviate("Halley's Comet")); //HC
            Console.WriteLine(Abbreviate("The Road _Not_ Taken")); //TRNT

        }
        public static string Abbreviate(string phrase)
        {
            string[] words = phrase.Split(new Char[] { ' ', '-' });
            StringBuilder sb = new StringBuilder();
            foreach(var word in words)
            {
                sb.Append(GetFirstUpperLetter(word));
            }
            return sb.ToString();
        }
        public static string GetFirstUpperLetter(string word)
        {

            foreach(var ch in word)
            {
                if(char.IsLetter(ch))
                    return ch.ToString().ToUpper();
            }
            return "";
            
        }

    }
}
