using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        ushort n = ushort.Parse(Console.ReadLine());
        BigInteger result = BigInteger.Pow(n, n);
        Console.WriteLine(result);
    }
}