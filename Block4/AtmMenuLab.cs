using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block4
{
    internal class AtmMenuLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gringotts ATM");

            decimal balance = 700.00m;

            Console.WriteLine("Select an option: B) Balance D) Deposit W) Withdraw X) Exit");
            string userChoice = Console.ReadLine().ToUpper();

            switch (userChoice)
            {
                case "B":
                case "BALANACE":
                    Console.WriteLine("You have {0:c} in your account.\n\n", balance);
                    break;
                case "D":
                case "DEPOSIT":
                    Console.Write("\nHow much would you like to deposit: $");
                    decimal deposit = decimal.Parse(Console.ReadLine());
                    balance += deposit;
                    Console.WriteLine("{0:c} has been deposited in your account. Your balance is now {1:c}.\n\n", deposit, balance);
                    break;
                case "W":
                case "WITHDRAW":
                    Console.Write("\nHow much would you like to withdraw: $");
                    decimal withdraw = decimal.Parse(Console.ReadLine());
                    if (withdraw <= balance)
                    {

                        balance -= withdraw;
                        Console.WriteLine("{0:c} has been withdrew from your account. Your balance is now {1:c}.\n\n", withdraw, balance);
                    }
                    break;
                case "E":
                case "EXIT":
                case "X":
                    Console.WriteLine("Thank you for using Gringotts for your magical banking. We hope you have a wonderful day.");
                    break;
                default:
                    Console.WriteLine("Input not recognized.\n");
                    break;
            }

        }
    }
}