using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLock5
{
    internal class LoopingWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping with While");
            Console.Title = ("<(000)^/(0)>");

            /*
             * While Loops: best for when you want to run code an indeterminable number of times.
             * 0- infinity
             * 
             * COUNTER;
             * 
             * while (condition)
             * { 
             *   //code to run
             *   UPDATE
             *   }//end while
             * 
             * 
             */
            int cookie = 1; //counter

            while (cookie <= 5) //condition. no semicolon
            {
                Console.WriteLine($"Yum! You have eaten  { cookie} cookie {(cookie == 1 ? "" : "s")} .");
                cookie++;


            }

            int bags = 10;
            while (bags > 0)

            {
                Console.WriteLine("You have {0} bags of groceries remaining. Unloading one now...", bags);
                bags--;
            }


            bool moreBags = true; //COUNTER
            while (moreBags)//CONDITION
            {
                Console.WriteLine("\nYou have unloaded some groceries");
                //ask if they have more bags.
                Console.WriteLine("Do you have more bags? Y/N:");
                //ConsoleKey -- an enum
                ConsoleKey userAnswer = Console.ReadKey(false).Key;


                if (userAnswer == ConsoleKey.N)
                {
                    moreBags = false;


                }
            }

            Console.WriteLine("Would you like to play a game? Y/N: ");
            string runProgram = Console.ReadKey(false).Key.ToString();

            while (runProgram == "Y")
            {
                Console.WriteLine("YOU WIN");
                Console.WriteLine("You win!");
                Console.Write("\nPlay again? Y/N: ");
                runProgram = Console.ReadKey(false).Key.ToString();//UPDATE
            }














            Console.Write("\n\nAll code has been exceuted. Press any key to terminate the application....\n");
            Console.ReadKey(true);


        }
    }
}
       
