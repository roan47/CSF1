using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLock5
{
    internal class LoopingForEach
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping foreach");

            /* FOREACH is a specialized loop made for collections.
             * It provides READONLY access
             * You can see the values in the collection, but you
             * can NOT change them in a foreach.
             * 
             * foreach (DATATYPE MADEUPNAME in COLLECTION)
             * {
             *      //code to run with MADEUPNAME
             * }
             * 
             * This is the easiest, least error-prone loop. 
             * It is preferred in many program contexts,
             * but we lose some flexibility with it.
             * 
             * The foreach-loop is versatile.
             * We will end up using them in strings,
             * arrays, and even DataTables.
             */

            string[] colors = { "red", "blue", "green", "peachpuff", "purple", "black" };

            foreach (string color in colors)
            {
                Console.WriteLine(color.ToUpper());




            }

            // foreach (string color in colors)
            //{
            // color = "teal"
            //} for each holding variables are read only

            decimal[] prices = { 15.95m, 9.99m, 20, 10, 9.75m };
            foreach (decimal price in prices)
            {
                Console.WriteLine($"{prices:c}");

            }

            decimal totalSale = 0;
            Console.WriteLine("\nThank you for shopping at ToysRUs\n");
            foreach (decimal price in prices)
            {
                totalSale += price;
                //totalSale = totalSale + price;
                Console.WriteLine($"After adding {price:C}, your total is now: {totalSale:C}");

            }
            Console.WriteLine($"Your total purchase price: {totalSale:c}");

            //Remeber, strings are also a collection of chars
            string letters = "abcdefghijklmnopqrstuvwxyz";
            foreach (char letter in letters)
            {
                Console.WriteLine(letter);

            }

            Console.WriteLine(letters.Length);

            Array.ForEach(prices, price => Console.WriteLine(price));












        }
    }
}
