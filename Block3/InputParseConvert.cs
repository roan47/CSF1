using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class InputParseConvert
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Capturing input, parsing, and converting");

            #region Input/Output Notes
            /*
             * There are 2 main options for output in console:
             * Write() and WriteLine()
             * 
             * WriteLine() adds a line break after your output.
             * Write() does not.
             * 
             * There are 3 options for Input in console:
             * 
             * Read() - Only takes 1 keystroke of input and stores the
             * ascii value of the key.
             * ReadKey() - Similar idea, but captures the key's
             *              character value 
             * ReadLine() - Most common. It allows the user to input
             * something and reads the input as a string after they
             * hit enter.
             *  
             * The important part is capturing or using the information
             * they gave you.
             * */
            #endregion

            string firstName = "Doctor Jan", lastName = "Itor";
            
            Console.Write(firstName);
            Console.Write(" " + lastName);

            Console.WriteLine(" - and now a line break...");

            Console.ReadLine();

            /*
             * you cannot put any code inside the parens of a ReadLine() method.
             * Using Readline() by itself without storing the input or using that
             * input immediately, results in the input beiung lost
             * 
             * */

            //Steps to gather & store user input
            //Step 1 - Explain to the user what they should type (try to be descriptive)
            //Step 2 - Allow them to type with ReadLine(), ReadKey(). or Read()
            //Step 3 - Capture their input into a variable for storage OR use the value immediately

            //step 1
            Console.WriteLine("What is your full name?");

           
            //step 2/3
            string userFullName = Console.ReadLine();

            //finally, use that info that you have captured
            Console.WriteLine("Hello, " + userFullName + "!");

            //Another example
            //Step 1
            Console.WriteLine("What is your quest");

            String userQuest = Console.ReadLine();

            Console.WriteLine(userQuest + "is a silly quest...");

            //MINI LAB!
            //Ask the user for their favorite color.


            Console.WriteLine("What is your favorite color");

            String usercolor = Console.ReadLine();

            Console.WriteLine(usercolor + "is a terrible color");

            Console.Write("you should pick something else");


            //interpolation
            Console.WriteLine($"{usercolor}is a terrible color");

            //String placeholders
            Console.WriteLine("{0} is a terrible color!", usercolor);

            //---- ReadLine() ALWAYS returns a string
            //We need to do extra work when expecting numeric input from a user.
            //to accomplish this, we can cast (dataType), or Parse(), or Convert().
            //ALL 3 methods will transform a string into another data type
            //SYNTAX: [dataType].Parse([stringValue])

            //Parsing example
            Console.WriteLine("What's your age again");
            string userAge = Console.ReadLine();

            //Calculate the number of years until the user turns 100 and display that info
            int yearsTo100 = 100 - int.Parse(userAge);//MUST convert/parse userAge string into a numeric data type to do calculations

            Console.WriteLine($"Only {yearsTo100} more years until you are 100!!!!");

            Console.WriteLine("How much would you like your salary to be?");
            string userSalary = Console.ReadLine(); 

            decimal annualSalary = decimal.Parse(userSalary);

            Console.WriteLine($"Thats quiet the number! Did you know that {annualSalary * .35m} will go to taxes");

            /*
             * ALL of the data types we have used up to this point are "intrinsic" or "simple"
             * data types that have their own reserved C# keyword. (int, bool...)
             * THese keywords are simply aliases for a class that exists in the .NET framework.
             * The class is what we call the 'true data type'
             * 
             * keyword--> true data type
             * int--> Int32
             * byte--> byte
             * short-->Int16
             * Long-->Int64
             * decimal--> Decimal
             * double-->Double
             * string-->String
             * bool--> Boolean
             * 
             *syntax for using Convert.To [DataTyoe]
             *Covert.To[TrueDataType]([valueToConvert])
             **/

            //Ask the user how manty times they have been smuggled by Han& Chewie
            //Inform them that they will get a free light saber after their 10th trip

            Console.WriteLine("How many times have you been smuggled through Imperial lines by Solo & Chewie?");

            string nbrTimesSmuggled = Console.ReadLine(); 

            short convertedTimesSmuggled = Convert.ToInt16(nbrTimesSmuggled);

            Console.WriteLine($"You Have {10 - convertedTimesSmuggled} more trips to get your free lightsaber!");













        }
    }
}
