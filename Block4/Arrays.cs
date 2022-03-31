using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            /*
           * An array stores a fixed-size sequential collection of 
           * objects of the same type. 
           * 
           * An array is used to store a collection of 
           * data, but it is often more useful to think of an array as 
           * a collection of variables of the same type.
           * 
           * Standard Arrays: 
           * 
           * - Have a fixed size (can't change it programmatically)
           * - The size is called the Length (1-based counting)
           * - Uses 0-based counting for the positions of the indexes.
           * - Type safe
           * - Use the "new" keyword to call the "constructor" that builds the object
           */

            string[] dresser = new string[4];
            //created a string array called dresser and assigned is a length of 4
            dresser[0] = "Shirts"; //in the drawer with an index of 0, put shirts.
            dresser[1] = "pants";
            dresser[3] = "socks";
            dresser[2] = "shorts";

            //Each index is called by arrayName [Indexnumber]
            Console.WriteLine($"{dresser[3]} is in the last drawer.");
            dresser[3] = "t-shirts";

            Console.WriteLine($"{dresser[3]} are in the 4th drawer with an index of 3 ");

            Console.WriteLine($"{dresser[1]} are in index 1 and {dresser[2]} are in index 2");


            //To explore an object in intellisense, use a period.
            Console.WriteLine(dresser.Length + "is the length of trhe array");
            //Length will ALWAYS be 1 MORE than the last index.
            //the first indexn is always 0

            Console.WriteLine("The first item is " + dresser[0]);

            //The last index is always 1 less than the length.
            Console.WriteLine("The last item is" + dresser[dresser.Length- 1]);
            Console.WriteLine($"The last item is {dresser[^1]}");//index operator. Appears to do the same as above.

            decimal[] prices = new decimal[5];
            prices[0] = 24.99m;
            prices[1] = 100;
            prices[2] = 50;
            prices[3] = 9.75m;
                prices[4] = 200;
            //if you see an IndexOutOfBounds runtime error, you've tried to access or set an index that doesn't exist.

            Console.WriteLine($"{prices[1]:c}");

            Console.WriteLine(prices);
            //The compiler does not know how to format complex datatypes by default, so attempting to print a 
            //complex datatype to the screen will usually result in an output of 
            //namespace.className where the class is defined.
           //ecimal totalSale = prices[0] + prices[1] + prices[2] + prices[3] + prices[4];
            decimal totalSale = prices.Sum();
            Console.WriteLine("Total sale: {0:c}", totalSale);
          
            Console.WriteLine($"Prices has {prices.Length} indexes.\n" +
              $"1st Index holds {prices[0]:c}\n" +
              $"The last Index holds {prices[prices.Length - 1]}");

            //.Sort() called from the Array Class, Array.sort(arrayname).
            //ascending Sort

            Array.Sort(prices);
            Console.WriteLine($"Prices has {prices.Length} indexes.\n" +
           $"1st Index holds {prices[0]:c}\n" +
           $"The last Index holds {prices[prices.Length - 1]}");

            Array.Reverse(prices);
            Console.WriteLine($"Prices has {prices.Length} indexes.\n" +
                $"1st Index holds {prices[0]:c}\n" +
                $"The last Index holds {prices[prices.Length - 1]}");

            //You MUST know all of the values you want to put into the boxes first. This is called
            //"Collection Initialization" syntax.
            string[] toolbox =
            {
                "wrenches",
                "screwdrivers",
                "sockets",
                "hammers",
            };

            int number = 42;
            int anotherNumber = 987;

            int[] numbers = { 50, number, 87, anotherNumber, 27 * 13 };
            bool[] boolpen = { true, false, false , false, true };

            string stringname = "James Bond";
            // .IndexOf(" ") returns the index location of a specified char in the string.
            int location = stringname.IndexOf(" ");
            string firstName = stringname.Substring(0, 5);
            Console.WriteLine(firstName);
            //string firstName = stringname [..location];//does the same thing as above
            //string firstname = stringname.substring(0, locationg);

            string Lastname = stringname.Substring(location + 1);
            Console.WriteLine(Lastname);


        }
    }
}
