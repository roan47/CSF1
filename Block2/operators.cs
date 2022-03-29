using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2
{
    internal class Operators
    {
        static int Main(string[] args)

        {
            Console.WriteLine("Mathematical Operators\n");

            //Concatenation "+" -- "&"
            Console.WriteLine(3 + 5);//adding two literal numbers
            Console.WriteLine(3 + "5");//35 because it's concatention 

            Console.WriteLine(12 - 8);
            Console.WriteLine(10 / 5);
            Console.WriteLine(2 * 11);

            int legos = 15 + 27;

            // it takes 9 legos to make a car. How many cars can we make
            int legoCars = legos / 9;
            Console.WriteLine("We can make" + legoCars + " cars.");
            int piecesLeftOver = legoCars % 9;
            Console.WriteLine(piecesLeftOver + " remaining pieces.");

            //We have 75 nails. It takes 30 nails to make a dresser.
            //How many dressers can we make, and how mnay nails would be left over? 
           
            int nails = 75;
            int dressersMade = nails / 30;
            int nailsLeftOver = nails % 30;

            Console.WriteLine("\nWhole Dressers: " + dressersMade +
                          "\nNails Left Over: " + nailsLeftOver);
           
            Console.WriteLine();


            //Unary Operator
            //increment/decrement a variable's value.

            int hobbits = 2;
            Console.WriteLine("Hobbits: " + hobbits);

            hobbits = hobbits + 1;
            Console.WriteLine("Hobbits: " + hobbits);

            hobbits++;
            Console.WriteLine("hobbits: " + hobbits);

            //variable++ is a POST-FIX unary operator (Happens LAST)
            //++variable is a PRE-FIX unary operator (Happens FIRST)

            int goblins = 12, orcs = 1;
            int badGuys = goblins + orcs++;

            Console.WriteLine("badGuys was assigned BEFORE orcs is incremented to two. " + badGuys);
            Console.WriteLine(orcs);

            Console.WriteLine();
            int xboxGames = 12, psGames = 1;
            int games = xboxGames + ++psGames;

            Console.WriteLine("games was assigned AFTER psGames is incremented to two" + games);
            Console.WriteLine(games);
            //psGames++ //psGames = psGames + 1;
            //int games = xboxGames + psGames;

            //Assignment Operators
            //= assigns the value on the right into the variable on the left
            // *=, -=, *=, /=, %=
            Console.WriteLine();

            int players = 2;
            Console.WriteLine(players);

            //Long way to add 4 to players:
            players = players + 4;
            Console.WriteLine(players);//6

            //shortcut:
            players += 4;
            Console.WriteLine(players);//10

            //Multiply by 3 the long way:
            players = players * 3;
            Console.WriteLine(players);//30

            //shortcut
            players *= 3;
            Console.WriteLine(players);//90

            //divide by 3
            players = players / 3;
            Console.WriteLine(players);

            players /= 3;
            Console.WriteLine (players);

            //subtract 8 the long way
            players = players - 8;
            Console.WriteLine(players);//2

            //Subtract 8 the short way
            players -= 8;//-6

            //Modulus 2 using shortcut only

            players %= 2;
            Console.WriteLine(players);//0
           
            //%2: if there is a remainder (1), then the number is odd. Otherwise, it's even.

            Console.WriteLine(67 % 2);//1 - Odd
            Console.WriteLine(888 % 2);//0 - Even 

            Console.WriteLine();

            //OoO - Order of Operations
            //PE(MD)(AS) - BODMAS
            int newCalc = 5 + 3 * 6 / 2 + 12;
            Console.WriteLine(newCalc + " without parens");

            int newCalc2 = (5 + 3) * 6 / 2 + 12;//
            Console.WriteLine(newCalc2 + " with parens");



        } // end Main()
    } // end class
} // end namespace
