using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    internal class Logic
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Logical and Comparison Operators");

            /*
             * Comparison Operatorss
             * Relationship and equality operators -> operators that compare 2 different
             * Values and result in a boolean answer of true or false
             * 
             * > greater than
             *      5 > 3 -> true
             *      3 > 5 -> false
             * < less than
             *   3 < 5 -> true
             *   5 < 3 -> flase
             *
             *>- greater than or equal to
             *    3 > -2 -> true
             *    3 >-3 -> true
             *
             *<- less than or equal to
             *    2 < -3 -> true
             *    2 < -2 -> true
             *    
             *-- is equal to
             *   3 -- 3 -> true
             *   3 -- 2 -> false
             *   
             * 
             * */

            int ceoPayGrade = 20;
            int mgrPayGrade = 12;
            int mailRoomPayGrade = 2;

            bool isCeoPayHigher = ceoPayGrade > mgrPayGrade;

            Console.WriteLine("Is the CEO paid more than the manager? " + isCeoPayHigher);

            Console.WriteLine("Is the Manager paid more than the CEO " + (mgrPayGrade > ceoPayGrade));

            Console.WriteLine("Is the mailroom less than or equaln to the ceo? " + (mailRoomPayGrade <= ceoPayGrade));

            Console.WriteLine("Is the Manager paid a different amount than the CEO? " + (mgrPayGrade != ceoPayGrade));



            //Logical operators combine two comparison operators or bool values and returns a bool.
            //&& is used for AND (meaning  BOTH conditions must be true)
            //|| is used for OR ( meaning at least one of the conditions must be true)

            bool payComparison = ceoPayGrade > mailRoomPayGrade && ceoPayGrade < mgrPayGrade;
            Console.WriteLine("Is CEO less than mgr AND CEO greater than mail room? " + payComparison);

            bool payComparisonWithOr = (ceoPayGrade > mailRoomPayGrade) || (ceoPayGrade < mgrPayGrade);
            Console.WriteLine("Is CEO less than mgr OR CEO greater than mail room? " + payComparisonWithOr);

        }    

            


    }//end class
}// end namespace
