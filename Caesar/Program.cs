using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a string to encrypt:");
            string UserString = Console.ReadLine();

            Console.WriteLine("\n");

            Console.Write("Enter your Key:");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");


            Console.WriteLine("Encrypted Data");

            string cipherText = Encrypt(UserString, key);
            Console.WriteLine(cipherText);
            Console.Write("\n");

            Console.WriteLine("Decrypted Data:");

            string t = Decrypt(cipherText, key);
            Console.WriteLine(t);
            Console.Write("\n");

        }
        public static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
                return ch;
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }
        public static string Encrypt(string plaintext, int key)
        {
            string ciphertext = string.Empty;
            foreach(var ch in plaintext)
            {
                ciphertext += Cipher(ch, key);
            }
            return ciphertext;
        }
        public static string Decrypt(string ciphertext, int key)
        {
            return Encrypt(ciphertext, 26 - key);
        }

    }
}
