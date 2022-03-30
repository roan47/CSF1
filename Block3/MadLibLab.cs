using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class MadLibLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please answer the following questions to the best of abilities, for time enter:day,night,morning,verb enter run,wallk,swim,etc");
            Console.WriteLine("noun/pronoun");
            string noun = Console.ReadLine();
            Console.WriteLine("verb");
            string verb = Console.ReadLine();
            Console.WriteLine("adjective");
            string adjective = Console.ReadLine();
            Console.WriteLine("noun");
            string noun2 = Console.ReadLine();
            Console.WriteLine("time");
            string time=Console.ReadLine();
            Console.WriteLine("city");
            string city = Console.ReadLine();
            Console.WriteLine($"Soon {noun} had nowhere left to go, as they{verb} to {city} they realized it was {time} but felt as if hours had flew by,{noun2} patted him on the back");




        }
    }
}
