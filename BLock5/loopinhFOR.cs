using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLock5
{
    internal class loopinhFOR
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping with FOR");


            /*
                * FOR LOOP SYNTAX
                * 
                * for (COUNTER; CONDITION; UPDATE)
                * {
                *      //code to run
                * }
                * 
                * Some books refer to COUNTER as INITIALIZER
                * //! Mnemonic device: ICU 
                * 
                * Counter - the starting point where you initailize a 
                * variable that is used to check the condition. The 
                * counter gets updated after each pass through the loop.
                *
                * Condition - A Boolean statement that tells the loop
                * when to stop. It is checked before each pass.
                * 
                * Update - the change to the counter after each 
                *          pass of the loop (increment, decrement, etc.)
                * 
                * Remember: a for loop is best used when you know exactly 
                *           how many times you want to run the code
                *           
                * For loops are common and useful in many algorithms 
                * and methods in the C# language
                */


            for (int candybar = 1; candybar <= 7; candybar++)
            {
                Console.WriteLine("Yum! You have had " + candybar + "candy bar!");

            }

            //grapes += 3 //grapes = grapes + 3
            for (int grapes = 3; grapes <= 15; grapes +=3)
            {
                Console.WriteLine($"You ate 3 grapes and have now {grapes} total.");
            }

            //count to 20 but skip 13.
            for (int count = 1; count <= 20; count++)
            {
               if (count != 13)//! think not
                Console.WriteLine(count);
            }
            //continue keyword stops the current iteration of the loop and moves on to the next iteration.

            for (int count = 1; count <=20; count++)
            {
                if (count == 13)
                {
                    continue;

                }
                                Console.WriteLine(count);            }
            //break; stops the whole loop, continue; stops only the current iteration.
            //stringVariable += "some more string\n"
            //Running Total Variables
            //Create a variable in an outerscope sp we can make changes to it in an inner scope
            string listOfName = ""; //typically called an empty string;
            Console.WriteLine("\n\nREGISTRATION\n");
            Console.WriteLine("How many people would you like to " +
                "register for comic-con");
            int total = Convert.ToInt32(Console.ReadLine());

            for (int reg = 0; reg < total; reg++)
            {
                Console.WriteLine("Please enter a name: ");
                listOfName += Console.ReadLine() + "\n";
            }

            Console.WriteLine($"\nYou have registered:\n{listOfName}");


            //we can loop through (iterate through) a collection with a for statement
            decimal[] prices = { 15.96m, 9.9m, 20, 10, 9.75m };

            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine($"At the index of {i} is {prices[i]:c}");
            }
            Console.WriteLine($"The total is: {prices.Sum():c}");

            //for (int i = 1; i > 0; i++)





         }
    }
}
