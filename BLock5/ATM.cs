using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLock5
{
    internal class ATM
    {
        static void Main(string[] args)
        

        
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Mans Last Bank";
            Console.ReadKey();
            Console.WriteLine("WElCOME TO");
            Console.WriteLine(@"

   *                       (                                               
 (  `                      )\ )               )     (                   )  
 )\))(      )             (()/(     )      ( /(   ( )\     )         ( /(  
((_)()\  ( /(   (     (    /(_)) ( /(  (   )\())  )((_) ( /(   (     )\()) 
(_()((_) )(_))  )\ )  )\  (_))   )(_)) )\ (_))/  ((_)_  )(_))  )\ ) ((_)\  
|  \/  |((_)_  _(_/( ((_) | |   ((_)_ ((_)| |_    | _ )((_)_  _(_/( | |(_) 
| |\/| |/ _` || ' \))(_-< | |__ / _` |(_-<|  _|   | _ \/ _` || ' \))| / /  
|_|  |_|\__,_||_||_| /__/ |____|\__,_|/__/ \__|   |___/\__,_||_||_| |_\_\  ");
            bool acess = false;
            Console.WriteLine("Please enter your life number");
          string lifeNumber =  Console.ReadLine();
            if (lifeNumber == "0001")
            {
                acess = true;
                Console.WriteLine("Enjoying your last days?");


            }
            else
            {
                Console.WriteLine("You have thought you were someone else");

            };

            if (acess)

            {
                int loginattempts = 0;
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Please Enter Life Pin");
                    string lifePin = Console.ReadLine();
                    if (lifePin != "86")
                        loginattempts++;
                    else
                        break;

                }





                if (loginattempts > 2)
                    Console.WriteLine("You are attempting to be someone your not");
                else
                {
                    Console.WriteLine("Welcome to Mans Last ATM");



                    decimal balance = 10000m;

                    for (; ; )
                    {

                        


                        Console.WriteLine("Select an option: B) Balance D) Deposit W) Withdraw X) Exit");
                        string userChoice = Console.ReadLine().ToUpper();



                        switch (userChoice)
                        {
                            case "B":
                            case "BALANCE":
                                Console.WriteLine("You have {0:c} in your account.\n\n", balance);
                                continue;
                            case "D":
                            case "DEPOSIT":
                                Console.Write("\nHow much would you like to deposit: $");
                                decimal deposit = decimal.Parse(Console.ReadLine());
                                balance += deposit;
                                Console.WriteLine("{0:c} has been deposited in your account. Your balance is now {1:c}.\n\n", deposit, balance);
                                continue;










                            case "W":
                            case "WITHDRAW":
                                Console.Write("\nHow much would you like to withdraw: $");
                                decimal withdraw = decimal.Parse(Console.ReadLine());
                                if (withdraw <= balance)
                                {

                                    balance -= withdraw;
                                    Console.WriteLine("{0:c} has been drained from your Life,balance is now {1:c}.\n\n", withdraw, balance);
                                }
                                continue;








                            case "E":
                            case "EXIT":
                            case "X":
                                Console.WriteLine("ENJOY YOUR LAST DAYS ON EARTH");
                                break;

                            default:
                                Console.WriteLine("SOMETHING IS WRONG\n");

                                continue;

                        }
                        break;





                    }

                }


            }
                    



                    













            





































































            }



        }
    
}
