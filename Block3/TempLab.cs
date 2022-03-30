using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class TempLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input degrees in celcius");
              
            string degreesCelcius = Console.ReadLine();


            int farenheit = 30 + 2*int.Parse(degreesCelcius);

            Console.WriteLine($"The tempature {farenheit} is in farenheit");

            Console.WriteLine("input degrees in farenheit");

            string degreesfarenheit = Console.ReadLine();

            int celcius = int.Parse(degreesfarenheit) / 2 - 30;

            Console.WriteLine($"The tempature {celcius} is in celcius");









        }
    }
}
