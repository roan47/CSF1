using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class Branchingswitch
    {
        static void Main(string[] args)
        {

            /*
             * SYNTAX:
             * 
             * switch (valueToCheck)
             *{
             * case TEST
             *      //code
             *      break;
             *  case ...
             *      //code
             *      break;
             *  dedefault:
             *       //code
             *       break;
             *       }
             *       
             *  /
             */


            Console.WriteLine("Enter a number?");
            short userNumber = short.Pase(Console.ReadLine());

            switch (userNumber)
            {
                case 1:
                    Console.WriteLine("You typed 1");
                    break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                case 42:
                    Console.WriteLine("you typed 2-5 or 42");
                    //treats multiple cases like ||
                    break;
                    default:
                    Console.WriteLine("You picked something else");
                    break;

            }//end switch


            //if you see error you missed a break

            Console.WriteLine("\n\nPlease choose a program to run.\n" +
                "1) Numbers\n" +
                "2) Drawing\n" +
                "3) Water Lab\n" +
                "4) ChangeLab\n");

            string userOption = Console.ReadLine().ToLower();
            switch (userOption)
            {
                case "1":
                case "numbers":
                case "n":
                    Console.WriteLine("1, 2, 3, 4, 5, 6, 7, ah, ah, ah");
                    break;
                case "2":
                case "drawing":
                case "d":
                    Console.WriteLine(@"Lookie! I made a sword!
                      
                    o===={::::::::::::::::::>
                      ");
                    break;
                case "3":

                case "water lab":
              
                case "w":
                case "water":
                    Console.WriteLine("Water Lab!");
                    break;
                case "4":
                case "change lab":
                case "change":
                case "c":
                    Console.WriteLine("Change Lab");
                    break;
                default:
                    Console.WriteLine("Input not recognized, please restart and try again.");
                    break;

            }











            
        }
    }
}
