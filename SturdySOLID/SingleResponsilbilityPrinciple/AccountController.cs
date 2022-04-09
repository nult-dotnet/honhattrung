using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsilbilityPrinciple
{
    //This is where bank's methods are  
    internal class AccountController
    {
        public double balance;
        //Set up value for balance in the account
        public AccountController()
        {
            balance = 50000.00;
        }
        //This is deposit method
        public double deposit()
        {
            double deposit;
            double newBalance;
            Console.WriteLine("Please input the amount you wish to deposit");
            deposit = double.Parse(Console.ReadLine());
            newBalance = balance + deposit;
            return newBalance;
        }
        //this is withdraw method
        public double withdraw()
        {
            double withdraw;
            double newBalance;
            Console.WriteLine("Please input the amount you wish to withdraw");
            withdraw = double.Parse(Console.ReadLine());
            newBalance = balance - withdraw;
            return newBalance;

        }
    }
}
