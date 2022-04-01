using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class fruitLab
    {
        static void Main(string[] args)
        {

            string[] fruits = new string[5];
            fruits[0] = "Banana";
            fruits[1] = "Grape";
            fruits[2] = "Strawberry";
            fruits[3] = "Rasberry";
            fruits[4] = "Dragonfruit";

            string abrv = fruits[0].Substring(0, 1);
            string abrv2 = fruits[1].Substring(0, 2);
            string abrv3 = fruits[2].Substring(0, 3);
            string abrv4 = fruits[3].Substring(0, 1);
            string abrv1 = fruits[4].Substring(0, 2);
          Console.WriteLine(abrv);
            Console.WriteLine(abrv2);
            Console.WriteLine(abrv3);
            Console.WriteLine(abrv4);
            Console.WriteLine(abrv1);


           

        }
    }
}
