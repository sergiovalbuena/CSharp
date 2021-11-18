using System;

namespace SuperBank2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with. {account.Balance}. ");

            account.MakeWhitdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);

            account.MakeWhitdrawal(50, DateTime.Now, "PS5");
            Console.WriteLine(account.Balance);


            Console.WriteLine(account.GetAccountHistory());

        }
    }
}
