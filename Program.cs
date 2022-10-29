using System;

namespace FinalProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Mortgage Calculator 1.0");
            Console.WriteLine("************************");
            Console.WriteLine();
            Console.WriteLine("Enter the details of your mortgage at the prompts");
            Console.WriteLine();

            int principal = (int)ConsoleReader.ReadNumber("Principal: ", 50000, 5000000);
            float annualInterest = (float)ConsoleReader.ReadNumber("Annual Interest Rate: ", 0, 30);
            byte years = (byte)ConsoleReader.ReadNumber("Period (Years): ", 0, 100);

        }
        
    }
    
}