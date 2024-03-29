﻿using System;

namespace _01BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        private static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        private static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
    }
}
