using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1
{
    internal class DataTypes
    {
        static void Main(string[] args)
        {
            /*
              Data Type             Bits           Value Range          Lesser Used Variant          Value Range

Bob            byte                  8              0 - 255             sbyte                         -128 - 127

Sure           short                 16             -32k - 32k          ushort                        0 - 65k

Is             int                   32             -2bil - 2bil        uint                          0 - 4bil

Loving         long                  64             -9quint - 9quint    ulong                         0 - 18quint
                */

            //1 0
            // 00000001 = 1
            // 00000010 = 2
            // 11010111 = 255


            // Declaration
            byte byteNbr;

            // Initialize
            byteNbr = 0;

            // Assignment
            byteNbr = 255;

            // declare & initialize
            short shortNbr = -1234;
            int intNbr = 1239687465;
            long longNbr = 109388175019804938;

            //lesser used variants
            sbyte sbyteNbr = -7;
            ushort ushortNbr = 654;
            uint uintNbr = 98838;
            ulong ulongNbr = 456516;

            //example of casting with truncation
            int someInt = (int)23.7;
            Console.WriteLine(someInt);

            //FLoating pont types
            float smallFraction = 12.3f;//32 bits, 45 digits
            double smallFraction2 = 12.9;//64 bits, 324 digits
            decimal smallFraction3 = 23.2093m; //128 bits, 29 digits. //Greatest accuracy, often used for money.
                                               //(decimal)23.2093 is the same as above, but it's easier to just type the "m" or "f"

            Console.WriteLine("Calculation Result: " + (smallFraction / 2));

            //Boolean - bit
            //Only accepts values of true or false

            bool isTheDoctor = false;

            Console.WriteLine("Are you the Doctor?" + isTheDoctor);

            isTheDoctor = true;
            //reassigning!

            Console.WriteLine("Are you the Doctor? " + isTheDoctor);

            //Char

            char letter = 'A';
            char symbol = '@';
            Console.Write(letter);
            Console.Write(symbol);

            //Concatenation
            string firstName = "James";
            string lastName = "Bond";

            Console.WriteLine(firstName + ' ' + lastName);
            Console.WriteLine(String.Concat(firstName, " ", lastName));

            //MINI LAB
            Console.WriteLine(lastName + "Bond" + firstName + "James" + lastName + "Bond") ;



        }// end Main()
    }//end class
}//end namespace

