using System;
using System.Collections.Generic;
using System.Text;


namespace SuperBank2
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();

        //CONSTRUCTOR
        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            //Balance = initialBalance;

            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWhitdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of whitdrawal must be positive ");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient fund for this whitdrawal");
            }
            var whitdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(whitdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            //HEADER
            report.AppendLine("Date\t\t\tAmmount\t\tNote");
            foreach (var item in allTransactions)
            {
                //ROW
                report.AppendLine($"{item.Date.ToShortDateString()}\t\t{item.Amount}\t\t{item.Notes}");
            }
            return report.ToString();

        }



    }
}
