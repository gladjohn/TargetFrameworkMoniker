using System;

namespace ConsoleAppNetCore2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 Kms = {0} miles", (KmstoMiles.Convert.ToMiles(1)));
        }
    }
}
