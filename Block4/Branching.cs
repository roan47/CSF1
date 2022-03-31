using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class BranchingIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Branching with if!");

            /* 
             
            if (condition) 
            {
                //code to run
            }
            else if (additional condition) { //code to run }
            else if (additional condition) { //code to run }
            else if (additional condition) { //code to run }
            else { //code to run }             
            */
            Console.WriteLine("What day is it? Monday, Tuesday, etc");
            string userDay = Console.ReadLine().ToLower();
            //.ToLower() -- .ToUpper() 

            if (userDay == "thursday")
            {
                //The code inside this scope will only run if the above condition resolves to true
                Console.WriteLine("I never could get the hang of Thursdays...");
            }//end if

            Console.WriteLine("Moving along...\n");

            int monsterStrength = 100;
            int heroStrength;
            Console.WriteLine("In this cave, you see bones and a white rabbit.");
            Console.Write("Enter your attack strength: ");
            heroStrength = Convert.ToInt32(Console.ReadLine());

            if (heroStrength > monsterStrength)
            {
                Console.WriteLine("You use the Holy Hand Grenade of Antioch and blow the rabbit to tiny bits");
            }//end if
            else if (heroStrength == monsterStrength)
            {
                Console.WriteLine("Alright, then. We'll call it a draw.");
            }//end else if
            else if (heroStrength >= monsterStrength * .75)
            {
                //75-99
                Console.WriteLine("You die a valiant death, but put up a great fight.");
            }//end else if
            else if (heroStrength > 0)
            {
                //1-74
                Console.WriteLine("You join the pile of bones!");
            }//end else if > 0
            else if (heroStrength > 20)
            {
                //This will NEVER run. In order for this condition to be true, one of the above conditions 
                //will already have been true and the tree exited.
                Console.WriteLine("You shouldn't be able to read this.");
            }//end else if
            else
            {
                // < 0
                Console.WriteLine("Dude... You're already dead...");
            }//end else

            bool runMe = true;
            if (runMe)
            {
                Console.WriteLine("\nProgram Running .... \n");
            }//end if

            bool isAdmin = false;
            Console.Write("Enter your username: ");
            string username = Console.ReadLine().ToLower();

            if (username == "jeremy" || username == "admin")
            {
                isAdmin = true;
            }//end if

            if (isAdmin)
            {
                Console.WriteLine("You're an admin!");
            }//end if


            //NESTING IFS

            Console.WriteLine("Shall we play a game?");
            string userProgram = Console.ReadLine().ToUpper();
            if (userProgram == "Y" || userProgram == "YES")
            {
                //Console.WriteLine("Program Running");
                Console.WriteLine("Type Frogger, Pacman, or War");
                string userGame = Console.ReadLine().ToLower();
                if (userGame == "frogger")
                {
                    Console.WriteLine("You're too slow... SPLAT!");
                }//end if
                else if (userGame == "pacman")
                {
                    Console.WriteLine("I calculate that you would lose! Boo!");
                }//end else if pacman
                else if (userGame == "war")
                {
                    Console.WriteLine("Global thermonuclear war executed.");
                }//end else if war
                else
                {
                    Console.WriteLine("Response not understood.");
                }//end else
            }//end outer if
            else if (userProgram == "N" || userProgram == "NO")
            {
                Console.WriteLine("We didn't want you to play our games anyway!");
            }//end else if no 
            else
            {
                Console.WriteLine("Response not understood. Please restart.");
            }//end else

            Console.WriteLine("Moving on...");

            Console.WriteLine("What was your score on the last klingon exam?");


            //MINILAB! Ask the user for the score on their last Klingon exam. 
            //tell them the letter grade. 90+ is A, 80-89 is B, 70-79 = C, 60-69 = D, anything less is an F.

            Console.Write("Enter the score on your klingon exam: ");
            byte testScore = byte.Parse(Console.ReadLine());

            if (testScore >= 90)
            {
                Console.WriteLine("Great job! You got an A!!");
            }//end if A
            else if (testScore >= 80)
            {
                Console.WriteLine("Fair job.... B");
            }//end if B
            else if (testScore >= 70)
            {
                Console.WriteLine("Adequate.. C");
            }//end if C
            else if (testScore >= 60)
            {
                Console.WriteLine("Poor.... D");
            }//end if D
            else
            {
                Console.WriteLine("Dude... Did you even try?");
            }//end if F










            //ternary operator
            //BooleanCondition ? trueResponse : falseResponse
            Console.Write("How many Daleks are there?");
            int dalekCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Oh, no! {0} Dalek{1}!",
                dalekCount,
                dalekCount == 1 ? "" : "s");

         
     

          


        }//end main()
    }//end class
}//end namespace