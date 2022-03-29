using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2
{
    internal class Casting
    {
        static void Main(string[] args)
        {
            #region Casting Notes
            /*
             * Casting is copying the value from a variable of one
             * type to a variable of a different, but similar type.
             * 
             * IMPLICIT Casting: copies the contents from a smaller
             * container to a larger container (aka data type).
             * This always fits.
             */
            #endregion

            byte toothpasteBox = 1;//255
            short shoeBox = 200;//32k
            int movingBox = 32261;//2 billion
            long fridgeBox;//9 quintillion

            fridgeBox = toothpasteBox;
            Console.WriteLine("fridgebox: " + fridgeBox);
            //implicit casting (byte to a long)
            //ALWAYS works because the value will always fit.

            long ovenBox = fridgeBox;//Not casting, because it's the same datatype

            //toothpasteBox = fridgeBox;
            /* 
             * EXPLICIT Casting - going from a larger to a smaller
             * container. This requires extra work.
             * 
             * You have to explicitly state the data type you're 
             * casting to. This can create issues if the value won't fit.
             * 
             * Explicit = Explain
             * 
             */
            //EXPLICIT Casting: short to a byte. No truncation.
            toothpasteBox = (byte)shoeBox;
            Console.WriteLine("shoeBox: " + shoeBox);
            Console.WriteLine("toothpasteBox: " + toothpasteBox);

            toothpasteBox = (byte)movingBox;
            Console.WriteLine("ToothpasteBox: " + toothpasteBox);
            //TRUNCATION: 10101110 10101110 10101110 00000101

            movingBox = (int)fridgeBox;//right to left thinking.
            Console.WriteLine(movingBox);
            //Cast the long into the int and display it.
            //TargetVariable = (TargetType)VariableToBeCast

            decimal dec1 = 4.3m;
           

            //both of the lines above are the same.
            //m or M is a shortcut for explicitly casting.

            decimal deathStars = 1.75m;
            int completedDeathStars = (int)deathStars;
            Console.WriteLine("Out of " + deathStars + "Death Stars, only" + completedDeathStars + "was completed");




        } // end Main()
    } // end Class
} // end Namespace

