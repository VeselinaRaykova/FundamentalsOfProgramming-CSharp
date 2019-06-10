using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        byte a = byte.Parse(Console.ReadLine()); // [0, 255]
        uint b = uint.Parse(Console.ReadLine()); // [0, 2^31]
        int c = int.Parse(Console.ReadLine()); // [-2^31, 2^31 - 1
        ulong d = ulong.Parse(Console.ReadLine()); // [-2^64, 2^64 – 1].

        Console.WriteLine(string.Format("{0} {1} {2} {3}", a, b, c, d));
    }
}
