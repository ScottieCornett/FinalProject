using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class ConsoleReader
    {
        public static double ReadNumber(string prompt, double min, double max)
        {
            double value;

            while (true)
            {
                Console.Write(prompt);
                value = Convert.ToDouble(Console.ReadLine());
                if (value >= min && value <= max)
                    break;
                Console.WriteLine($"Please enter a value between {min} and {max}");
            }
            return value;

        }
    }
}
