using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomewordV1
{
    class Login
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Login\n");

            int userAttempts = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter your account number: ");
                string accountNumber = Console.ReadLine().ToLower();
                string validAccountNumber = "11785";

                if (accountNumber != validAccountNumber) userAttempts++;
                else
                    break;
            }
            if (userAttempts > 2)
            {
                Console.WriteLine("Invalid entry.");
                return;
            }
            else
            {
                Console.WriteLine("Account number is comfirmend. Thank you.");
            }
                
        }
    }
}
