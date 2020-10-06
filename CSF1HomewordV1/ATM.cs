using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomewordV1
{
    class ATM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM!");
            
            //Account number confirmation
            int userAttempts = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter your account number: ");
                string accountNumber = Console.ReadLine().ToLower();
                string validAccountNumber = "11785";

                if (accountNumber != validAccountNumber)
                {
                    Console.WriteLine("Invalid entry.");
                    userAttempts++;
                }
                else
                    break;
            }
            if (userAttempts > 2)
            {
                Console.WriteLine("You have been locked out.");
                return;
            }
            else
                Console.WriteLine("Account number is comfirmend. Thank you.");

            //PIN confirmation
            int pinAttempts = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter your Personal Identification Number (PIN): ");
                string pinNbr = Console.ReadLine().ToLower();
                string validPinNbr = "4568";

                if (pinNbr != validPinNbr)
                {
                    Console.WriteLine("Invalid entry.");
                    pinAttempts++;
                }
                else
                   break;
            }
            if (pinAttempts > 2)
            {
                Console.WriteLine(" You have been locked out.");
                return;
            }
            else
                Console.WriteLine("Account confirmed!\n");

            //ATM Menu
            bool repeat = true;
            int balanceTotal = 0;

            for (int i = 0; i < 10; i++)
                do
                {
                    Console.Write("\nD) Deposit\nW) Withdraw\nA) Account Balance\nX) Exit");
                    string userChoice = Console.ReadLine().ToLower();

                    Console.Clear();
                    switch (userChoice)
                    {
                        case "D":
                        case "DEPOSIT":
                            Console.Write("Enter the ammount you want to deposite: ");
                            int deposit = Convert.ToInt32(Console.ReadLine());
                            balanceTotal = balanceTotal + deposit;
                            Console.WriteLine("\nYour current balance is: {o:c}", balanceTotal);
                            break;

                        case "W":
                        case "WITHDRAW":
                            Console.Write("Enter the amount you want to withdraw: ");
                            int withdraw = Convert.ToInt32(Console.ReadLine());
                            balanceTotal = balanceTotal - withdraw;
                            Console.WriteLine("\nYou have withdrawn: {0:c} from account number 11785.", withdraw);
                            if (balanceTotal >= withdraw)
                            {
                                Console.WriteLine("\nPlease collected your cash below.");
                                Console.WriteLine("\nYour new balance is: {0:c}", balanceTotal);
                            }
                            else
                               Console.WriteLine("\nInsufficient funds.");
                               break;

                        case "A":
                        case "Account Balance":
                            Console.WriteLine("Your current account balance: {0:c}", balanceTotal);
                            break;
                        case "X":
                        case "EXIT":
                            Console.WriteLine("\nThank you! Come again!\n");
                            repeat = false;
                            return;

                        default:
                            Console.WriteLine("Invalid entry. Try again.");
                            break;
                    }
                } while (repeat);
        }
    }
}
