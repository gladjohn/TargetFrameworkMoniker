﻿using System;

namespace ConsoleAppNetCore31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 Kms = {0} miles", (KmstoMiles.Convert.ToMiles(1)));
        }
    }
}
