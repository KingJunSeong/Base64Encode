using System;
using System.Text;

namespace Base64Encode
{
    class Program
    {
        public static string Base64Encode(string plaintext)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plaintext);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        static void Main(string[] args)
        {
            Console.Write("input : ");
            string text = Console.ReadLine();

            Console.WriteLine("text : " + text);
            string Encode = Base64Encode(text);
            Console.WriteLine("Encode : " + Encode);
        }
    }
}