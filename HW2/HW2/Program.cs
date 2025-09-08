using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter Collumn: ");
            int collumns = int.Parse(Console.ReadLine());

            List<List<double>> numbers = new List<List<double>>();
            double total = 0.0;

            for (int i = 0; i < rows; i++)
            {
                numbers.Add(new List<double>());
                Console.WriteLine($"Row {i + 1}");
                for (int e = 0; e < collumns; e++)
                {
                    Console.Write($"Enter Number {e + 1}: ");
                    double value = double.Parse(Console.ReadLine());
                    numbers[i].Add(value);
                    total += value;
                }
            }

            Console.WriteLine();

            Console.Write("The Numbers are:");
            for (int o = 0; o < numbers.Count; o++)
            {
                Console.WriteLine();
                for (int u = 0; u < numbers[o].Count; u++)
                {
                    Console.Write(numbers[o][u]+" ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Sum: {total}; Average: {total/ (rows * collumns)}");

            Console.ReadKey();
        }
    }
}
