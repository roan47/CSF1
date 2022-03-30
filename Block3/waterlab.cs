using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class waterlab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many gallons of water do you have?");
            string gallons = Console.ReadLine();
            decimal pounds = decimal.Parse(gallons);
            Console.WriteLine($"Did you know that is {pounds * 8.33m}pounds ");







        }
    }
}
