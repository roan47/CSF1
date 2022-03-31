using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2
{
    internal class operatorslab
    {
        static void Main(string[] args)
        {
            
            int sideofsquare = 75;
            Console.WriteLine(sideofsquare);


            sideofsquare = sideofsquare * 4;
            Console.WriteLine(sideofsquare);
           
            Console.WriteLine();

            int height = 45;

            int depth = 20;

            int length = 65;
            
            int volume = height * depth * length;
            Console.WriteLine(volume);
            
            Console.WriteLine();

            int people = 146;

            int peoplepervan = 9;
             
            int vans = people / peoplepervan;

            Console.WriteLine(vans);    

            Console.WriteLine();

            int cookies = 5;
            Console.WriteLine("cookies:" + cookies);

            cookies = cookies - 2;
            Console.WriteLine("cookies:" + cookies);

            Console.WriteLine();

            int aliens = 5;

            Console.WriteLine("their were 5 aliens on earth" + aliens);

            aliens = aliens - 1;

            Console.WriteLine("1 alien had left");

            aliens = aliens + 2;

            Console.WriteLine("2 more aliens cameback to earth so now their was" + aliens);

            aliens = aliens + 1;

            Console.WriteLine("one more alien came to earth");

            aliens = aliens - 6;

            Console.WriteLine("most of the aliens left in pairs leaving only" + aliens);    



















        }
    }

}
