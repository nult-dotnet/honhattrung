using System;

namespace SingleResponsilbilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountController bank = new AccountController();
            ErrorManagemnet _error=new ErrorManagemnet();
            double newBalance;
            string balance;
            Console.WriteLine("Your balance account is {0}" + " " + "VND",bank.balance);
            Console.WriteLine("Press d for deposit or press w for withdraw");
            balance = Console.ReadLine();
            try
            {
                if (balance == "d")
                {
                    newBalance = bank.deposit();
                    Console.WriteLine("Your new balance is {0}", newBalance);
                }
                if (balance == "w")
                {
                    newBalance = bank.withdraw();
                    Console.WriteLine("Your new balance is {0}", newBalance);
                }
            }
            catch (Exception ex)
            {

                _error.logError(ex);
            }
            
            Console.ReadKey();

        }
    }
}
