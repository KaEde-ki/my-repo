using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String: ");
            String[] input = Console.ReadLine().Split(' ');

           

                for(int i = 0; i < input.Length; i++)
                {
                int num = int.Parse(input[i]);

                if (isPrime(num))
                    Console.WriteLine($"{i + 1}. {num}\tPrime");
                else
                    Console.WriteLine($"{i + 1}. {num}\tComposite");
            }


            Console.Write("Enter currency in ($): ");
            String[] inputs = Console.ReadLine().Split(' ');

            Console.WriteLine("\nDollar($)\tPhil Peso(₱)\tJpn Yen(¥)");

            for (int i = 0; i < inputs.Length; i++)
            {
                double usd = double.Parse(inputs[i]);

                (double peso, double yen) = ConvertCurrency(usd);

                Console.WriteLine($"{usd}\t\t{peso}\t\t{yen}");
            }

            Console.ReadKey();
        }


        static bool isPrime(int input)
        {
            if (input <= 1) return false;

            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                    return false;
            }

            return true;

        }

        static (double, double) ConvertCurrency(double usd)
        {

            double peso = usd * 57.17;
            double yen = usd * 146.67;
            return (peso, yen);
        }

    }

 }
