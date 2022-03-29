//Adding // to the start of a line creates a single-line comment that is ignored by the compiler
/*
  this is a multiline comment
 */
//using statements-define resources from .NET that this file needs to be able to execute 
//In the current version of .Net, some using statements are implicit or automatically added by the compiler
//We will add them manually so you can see what is going on behind the scenes
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

//as you need different resoures from .NET, you will add each resource's using statement.

//a namespace refrera to the PROJECT your code lives in, Here, it is Block1. Namespaces are defined using PascalCase naming covention.

namespace Block1
{
    //  A Class is a file that contains code that your app will use to run. PascalCase

    class Variable
    {
        //method is the "verb" of the C# LAnguage
        //svm + tab + tab
        static void Main(string[] args)
        {
            // ctrl + k, ctrl + d -- Code formatting
            // ctrl + s -- save one document
            // ctrl + shift + s -- saves all documents
            // ctrl + b -- Build the solution
            // ctrl + F5 -- launch/run will also saven & build

            // C# is case sensitive. example and Example can be very different things.
            /*
             * 1. Declaration; create the container. give it a name and a datatype.
             * 2.  Initialization: Give the container a value for the first time.
             * 3. Assignment: Giving the container a new value any other time.
             */
            //datatype someName - variables are camelCase
            int firstExample;

            //string firstExample;  All variables within the same scope MUST be uniquely named.
            firstExample = 1;

            firstExample = 2;

            //Usually , variables are declared and initialized in the same line.
            string name = "John Doe";
            Console.WriteLine(name);

            name = "Luke Skywalker";
                Console.WriteLine(name);

            // Multiple variables can be defined on the same line, so long as they're all the same datatype.
            int burgers, frenchFries, onionRings = 3, milkShakes;
            burgers = 5;

            //CONSTANTS
            const int CURRENT_YEAR = 2022;
            //CURRENT_YEAR = 2023; constant's CANNOT be changed.

            Console.WriteLine(CURRENT_YEAR);

            // variables vs. literal values.
            int bigNbr = 55321; //don't use commas in numbers
            Console.WriteLine(bigNbr);
            Console.WriteLine(55321); //literal numbers
            Console.WriteLine("55321");//string literal

            //add two ints together
            Console.WriteLine(17 + 25);
            Console.WriteLine("17" + "25"); // Adding two strings together is called concatenation. 

            int kuBasketballPts = 1068;
            int muBasketballPts = 1003;

            Console.WriteLine("KU scored " + kuBasketballPts + " points in 15 games.");
            Console.WriteLine("Total KU & MU Points: " + (kuBasketballPts + muBasketballPts));

            //When using concatenation to print out a combination of text and numeric values,
            //use () around the mathematic operations to make sure the concatenation happens LAST








        }// end main ()
    } // end class

} // end namespace


