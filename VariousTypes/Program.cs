using System;

namespace VariousTypes
{
    public class Program
    {

        static int i = 3;
        static uint j = 9U;
        static short k = 19999;
        static long l = -9999999999L;
        static ulong m = 9999999UL;
        //
        static char copyrightSymbol = '\u00A9';
        //
        static float n = 99.9f;
        //
        static bool o = true;
        static bool p = 5 < 3;

        private static void Main(string[] args)
        {
            Console.WriteLine(i);
            Console.WriteLine($"valor de i: {i} ");
            Console.WriteLine($"valor de j: {j} ");
            Console.WriteLine($"valor de k: {k} ");
            Console.WriteLine($"valor de l: {l} ");
            Console.WriteLine($"valor de m: {m} ");
            //
            Console.WriteLine($"valor de copyrightSymbol: {copyrightSymbol} ");
            //
            Console.WriteLine($"valor de n: {n} ");
            //
            Console.WriteLine($"valor de o: {o} ");
            Console.WriteLine($"valor de p: {p} ");

        }
    }
}
