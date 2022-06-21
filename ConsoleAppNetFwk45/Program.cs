using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNetFwk45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 Kms = {0} miles", (KmstoMiles.Convert.ToMiles(1)));
            Console.Read();
        }
    }
}
