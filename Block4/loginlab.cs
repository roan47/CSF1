using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class loginlab
    {
        static void Main(string[] args)
        {

            bool access = false;
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();

            if (username == "roan")
            {
                access = true;
            }
            if (access)
            {
                Console.WriteLine("You now have access");
            }
            else
            {
                Console.WriteLine("access denied");
            };

           
             if (access)
                {
                Console.WriteLine("please enter secret answer for the week");
                string useranswer = Console.ReadLine();

                switch (useranswer)
                {
                    case "animals are cool":
                        Console.WriteLine("welcome on in my boy");
                    break;
                    case "beware of dog":
                        Console.WriteLine("pleasure to see you");
                        break;
                    case "i love gloriana":
                        Console.WriteLine("thats my baby");

                        break;
                    case "teddy bears cant fly":
                        Console.WriteLine("yes they can");
                        break;
                    case "dragons are awesome":
                        Console.WriteLine("eddy murphys wife");
                        break;
                    default:    Console.WriteLine("leave NOW!!");
                        break;







                }

            }
          
            





        }
    }
}
