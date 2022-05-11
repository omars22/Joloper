using System;

namespace Joloper_OS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Joloper OS 0.01.00";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;                                                                                     ;

            Console.WriteLine("JOLOPER INC. (C) V.0.01.00 All Rights Reserved.");
            Console.WriteLine("JOLOPER OS, Write Your Username: ");
            string userName = Console.ReadLine();
            Console.Write("Hello " + userName + "! Write Your Password So We Can Start To Set Up Your Joloper: ");
            string passWord = Console.ReadLine();
            Console.WriteLine("Welcome, this might take a few minutes, make sure to follow what the terminal is saying.");
            // Set Up Start
            Console.ReadKey();
        }
    }
}
