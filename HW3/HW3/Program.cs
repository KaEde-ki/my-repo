using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");

            strCount(Console.ReadLine().ToLower());

            Console.ReadKey();
        }

        static void strCount(string strs)
        {
            String[] sentences = strs.Split(',');

            foreach (string sentence in sentences)
            {
                string trimmedString = sentence.Trim();

                Dictionary<char, int> frequency = new Dictionary<char, int>();

                foreach (char letters in trimmedString)
                {
                    if (char.IsWhiteSpace(letters)) continue;

                    if (frequency.ContainsKey(letters))
                        frequency[letters]++;
                    else
                        frequency[letters] = 1;
                }
                Console.WriteLine(
                    string.Join(", ", frequency.Select(p => $"{p.Key}={p.Value}"))
                    );
            }
        }
    }
}
