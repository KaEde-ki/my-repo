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

            string str;

            while (true)
            {
                Console.Write("Enter sentence(* to cancel): ");
                str = Console.ReadLine().ToLower();

                if (str == "*")
                    break;

                string reversed = "";

                for(int i = str.Length - 1; i >= 0; i--)
                {
                    reversed += str[i];
                }

                Console.WriteLine($"Original: {str}");
                Console.WriteLine($"Reversed: {reversed}");

                if(str == reversed)
                {
                    Console.WriteLine("This is Palindrome.");
                }
                else
                {
                    Console.WriteLine("This is not a Palindrome.");
                }

            }
         }
      }
    }

