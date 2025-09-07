using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            String str = Console.ReadLine().ToLower();

            str = str.Replace(" ", "");

            char[] wordArray = str.ToCharArray();
            Array.Reverse(wordArray);
            string reversed = new string(wordArray);

            if(str == reversed)
            {
                Console.WriteLine("This is a palindrome.");
            }
            else
            {
                Console.WriteLine("This is not a palindrome.");
            }

            Console.ReadKey();
        }
    }
}
