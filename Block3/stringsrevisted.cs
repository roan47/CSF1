using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class StringsRevisited
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strings Revisited!!!");

            //You can use the ToString() to get the string version of any value from a variable of any datatype.
            //You call this method from the variable name.
            //This can be used to turn a value in any variable of any datatype into a string:
            int number = 42;
            string text = number.ToString();
            Console.WriteLine("Number is: " + text);
            Console.WriteLine(number.GetType());
            Console.WriteLine(text.GetType());

            //Another example:

            decimal someDecimal = 124154.2392m;
            string nbrString = someDecimal.ToString();
            Console.WriteLine(nbrString);
            Console.WriteLine(someDecimal);

            //In the console, it is useful for the ability to pass format specifiers to the ToString() to "format" numbers or dates
            Console.WriteLine(someDecimal.ToString("n") + " with n for number");

            //since "n" defaults to 2 places, you can also give it a number value to specify the exact places it should have after the period.

            Console.WriteLine(someDecimal.ToString("n6") + " with n6 formatting");

            Console.WriteLine(someDecimal.ToString("c") + " with currency formatting");

            Console.WriteLine(someDecimal.ToString("e") + " with exponential formatting");

            //let's show these with string formatting:
            Console.WriteLine("{0:n3} is n3 formatting and {0:c} is currency formatting", someDecimal);

            //String Interpolation:
            Console.WriteLine($"{someDecimal:n3}, {someDecimal:c}");


            //Escape sequences
            //Special codes used inside a string that ignore certain characters. In C# they begin with a \

            // \n creates a new line inside of a string
            Console.WriteLine("I love escapes!\nThey are easy!");

            // \" escapes the " and allows it to be used as a character
            Console.WriteLine("\"I like turtles\", Zombie Kid said.");

            // \\ to get a \ (you have to escape... the escape)
            Console.WriteLine("C:\\VS2015\\Projects\\CSF1");

            /* Making text easier to read on-screen with concatenation:
            * To create a longer string that is easy to read 
            * use concatenation
            */

            //verbatim character @
            //similar to escape but it captures ALL characters
            //LITERALLY

            //This includes spacing, but to show double quotes inside of a verbatim string, you have to use double double quotes
            //To start a verbatim string add @ before the double quotes
            string greeting = @"Julio says


""hello"" and that 
   
        file is at
                C:\julio\dox";

            Console.WriteLine(greeting);

            string froggy = @"           
                               .--._.--.
                              ( O     O )
                              /   . .   \
                             .`._______.'.
                            /(           )\
                          _/  \  \   /  /  \_
                       .~   `  \  \ /  /  '   ~.
                      {    -.   \  V  /   .-    }
                    _ _`.    \  |  |  |  /    .'_ _
                    >_       _} |  |  | {_       _<
                     /. - ~ ,_-'  .^.  `-_, ~ - .\
                             '-'|/   \|`-`
";
            //! Above image courtesy https://asciiart.website/ 
            //! Formerly Chris.com
            Console.WriteLine(froggy);

            //verbatim is often used for file locations:
            string fileLocation = @"C:\student\documents\ubergeek.doc";

            Console.WriteLine("This is the file location: " + fileLocation);//STRING CONCATENATION

            Console.WriteLine("This is the file location: {0}", fileLocation);//STRING FORMAT

            Console.WriteLine($"This is the file location: {fileLocation}"); //STRING INTERPOLATION

            //We can format strings without Console.WriteLine():
            string formattedString = string.Format("This is the file location: {0}", fileLocation);
            //This method is extremely useful, because it gives us a reusable string variable:
            Console.WriteLine(formattedString);

        }//end Main()
    }//end Class
}//end Namespace
