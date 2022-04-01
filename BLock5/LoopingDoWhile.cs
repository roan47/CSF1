using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLock5
{
    internal class LoopingDoWhile

    {

        
        static void Main(string[] args)
        {
            


            Console.WriteLine("Loooping with Do While");
            Console.Title = "LOOOOOOOOOPING WITH DO HAWHILE";

            /*
             * 
             * The doo while loop : best for when you only know the condition,
             * BUT you want it to run at least once, and as many times as p;possible after that.
             * (1 -> infinity)
             * 
             * COUNTER;
             * 
             * do
             * {
             *      ///code to run
             *      //update
             *      }
             *      while (condition);
             *      /
             */
            int cookie = 1;

            do
            {
                Console.WriteLine($"Yum! You have eaten  { cookie} cookie {(cookie == 1 ? "" : "s")} .");
                cookie++;


            } while (cookie <= 5); //condition dont forget the semicolon

            Console.WriteLine("\nDo you want to run this program? Y/N");
            string runProgram = Console.ReadKey (true).Key.ToString ().ToLower ();

            do
            {
                Console.WriteLine("Success! Program is running!\n");
                //could be thousands of lines of code
                Console.WriteLine("Keep going? Y/N");
                runProgram = Console.ReadKey(true).Key.ToString().ToLower();
            } while (runProgram == "y");//Condition;


            //**************************//

            bool quit = false;

           do
            {
                Console.Clear ();
                //do whiles ALWAYS run once. Best for menus!!!!!!!
                Console.WriteLine("-=Wekk Ant Eeru Phone Company=-");
                Console.WriteLine("B) Bill\nP) Payment\nX) Exit");
                string userChoice = Console.ReadKey(true).Key.ToString().ToLower ();

                Console.Clear ();
                switch (userChoice)
                {
                    case "b":
                        Console.WriteLine("Your balance is $500.00\n\n");
                        break;

                    case "p":
                        Console.WriteLine("Your payment is pending..\n\n");
                        break;

                    case "e":
                    case "x":
                    case "escape":
                        Console.WriteLine("Thank you for calling.");
                        quit = true;
                        break;

                    default:
                        Console.WriteLine("That was not a valid option.\n" +
                            "A $5 invalid option fee has been added to your credit card");
                        break;
                }

                Console.WriteLine("Press any key to return to the main menu..");
                Console.ReadKey(true);
            }
            while (!quit);





           








           
            
            
            
            
            Console.Write("\n\nAl code has been exceuted. Press any key to terminate the application....\n");
            Console.ReadKey(true);


        }


    }
}
