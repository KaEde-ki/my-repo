using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {



            /*Console.WriteLine("Hello World");
            Console.Write("Hello World\n");
            Console.Write("Enter num1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter num2: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Operator: ");
            String op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
                case "%":
                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                    break;
                default:
                    Console.WriteLine("Nigga you're a dumbass");
                    break;

            }*/

            Console.Write("Enter sentence: ");
            String str = Console.ReadLine().ToLower();

            for (int x = 0; x < str.Length; x++){

                String str2 = str[x] == 'a' ? "Vowel" : str[x] == 'e' ?
                    "Vowel" : str[x] == 'i' ? "Vowel" : str[x] == 'o' ?
                    "Vowel" : str[x] == 'u' ? "Vowel" : str[x] == ' ' ? "this is a space nigger" : "Consonant";
            

                Console.WriteLine($"{str[x]} {str2}");
            }
            


            Console.ReadKey();
        }

    }
}
