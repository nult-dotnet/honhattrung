using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsilbilityPrinciple
{
    class AccountBalance
    {
        // I try to make the console more advance but I stuck at the flow for the bank actions
        // and some methods that I haven't solved out. 
        private List<BankAccountEntry> bankAccounts=new List<BankAccountEntry>();
        //public void inputAccount(BankAccountEntry accountEntry)
        //{
        //    try
        //    {
        //        bankAccounts.Add(accountEntry);
        //    }
        //    catch (Exception ex)
        //    {

        //        logError(ex);
        //    }
            
        //}
        //public void updateAccount(BankAccountEntry )
        //{
        //    bankAccounts.
        //}
        //public void showAccount()
        //{
        //    try
        //    {
        //        foreach (var s in bankAccounts)
        //        {
        //            Console.WriteLine($"Account: {s.accountName}");
        //            Console.WriteLine($"Current balance: {s.balance}");

        //            if (bankAccounts.IndexOf(s) != bankAccounts.Count - 1)
        //            {
        //                Console.WriteLine();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        logError(ex);
        //    }
            

        //}

        //public void actions()
        //{
        //    string act;
        //    Console.WriteLine("Press d to deposit or press w to withdrawl");
        //    act = Console.ReadLine();
        //    if (act == "d")
        //    {
                
            
        //    }
        //}
        //public List<BankAccountEntry> getAccountBalance()
        //{
        //    return bankAccounts;
        //}
       
       
        //public double deposit()
        //{
        //    double deposit;
        //    double newBalance;
        //    Console.WriteLine("Please input the amount: ");
        //    deposit =double.Parse(Console.ReadLine()) ;
        //    newBalance=bankAccounts [0].balance + deposit ;
        //    return newBalance;
        //}
       

    }
}
