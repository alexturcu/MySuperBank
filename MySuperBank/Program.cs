using System;

namespace MySuperBank
{
    using BankyStuffLibrary;

    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
            account.MakeWithdrawal(5, DateTime.Now, "Coffee");
            account.MakeWithdrawal(5, DateTime.Now, "Diet Coke");
            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            account.MakeWithdrawal(7, DateTime.Now, "Tea");
            account.MakeWithdrawal(8, DateTime.Now, "Pants");

            Console.WriteLine(account.GetAccountHistory());

            //try
            //{
            //    account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw"); 
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}

            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}
        }
    }
}
