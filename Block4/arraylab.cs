using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class arraylab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 scores to see the min, max, and average.");

            int[] scores = new int [5];

            Console.WriteLine("1.) ");

            scores[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("2");

            scores[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("3");
            scores[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("4");
            scores[3] = int.Parse(Console.ReadLine());

            Console.WriteLine();

            scores[4] = int.Parse(Console.ReadLine());

            Array.Sort(scores);

            double average = scores.Average();

            int min = scores[0];
            
            int max = scores[scores.Length - 1];

            Console.WriteLine($"{min} {max} {average}");


           

        }
    }
}
