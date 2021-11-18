using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LoanApp
{
    class Loan
    {
        private double loanAmount;
        private double rate;
        private int numPayments;
        private double balance;
        private double totalInterestPaid;
        private double paymentAmount;
        private double principal;
        private double monthInterest;
        // Default constructor
        public Loan()
        {
        }
        // Constructor
        public Loan(double loan, double interestRate,
                    int years)
        {
            loanAmount = loan;
            if (interestRate < 1)
                rate = interestRate;
            else                             //In case directions aren't followed   
                rate = interestRate / 100;   // convert to decimal
            numPayments = 12 * years;
            totalInterestPaid = 0;
            DeterminePaymentAmount();
        }
        // Property accessing payment amount
        public double PaymentAmount
        {
            get
            {
                return paymentAmount;
            }
        }
        // Property setting and returning 
        // loan amount
        public double LoanAmount
        {
            set
            {
                loanAmount = value;
            }
            get
            {
                return loanAmount;
            }
        }
        // Property setting and returning rate
        public double Rate
        {
            set
            {
                rate = value;
            }
            get
            {
                return rate;
            }
        }
        // Property to set the numPayments, 
        // given years to finance.
        // Returns the number of years using
        // number of payments.
        public int Years
        {
            set
            {
                numPayments = value * 12;
            }
            get
            {
                return numPayments / 12;
            }
        }
        // Property for accessing 
        // total interest to be paid
        public double TotalInterestPaid
        {
            get
            {
                return totalInterestPaid;
            }
        }
        // Determine payment amount based on 
        // number of years, loan amount and rate
        public void DeterminePaymentAmount()
        {
            double term;
            term = Math.Pow((1 + rate / 12.0),
                              numPayments);
            paymentAmount = (loanAmount * rate /
                              12.0 * term) / (term - 1.0);
        }
        // Returns a string containing an
        // amortization table
        public string ReturnAmortizationSchedule()
        {
            string aSchedule = "Month\t\tInt.\t\tPrin.\t\tNew";
            aSchedule += "\nNo.\t\tPd.\t\tPd.\t\tBalance\n";
            aSchedule += "-------\t\t-------\t\t--------\t----------\n";
            balance = loanAmount;
            for (int month = 1; month <= numPayments; month++)
            {
                CalculateMonthCharges(month, numPayments);
                aSchedule += month
                          + "\t\t"
                          + monthInterest.ToString("N2")
                          + "\t\t"
                          + principal.ToString("N2")
                          + "\t\t"
                          + balance.ToString("C")
                          + "\n";
            }
            return aSchedule;
        }
        // Calculates monthly interest, 
        // applied principal and new balance
        public void CalculateMonthCharges(int month,
                                          int numPayments)
        {
            double payment = paymentAmount;
            monthInterest = rate / 12 * balance;
            if (month == numPayments)
            {
                principal = balance;
                payment = balance + monthInterest;
            }
            else
            {
                principal = payment - monthInterest;
            }
            balance -= principal;
        }
        // Calculates the amount of interest paid 
        // over the life of the loan
        public void DetermineTotalInterestPaid()
        {
            totalInterestPaid = 0;
            balance = loanAmount;
            for (int month = 1; month <= numPayments; month++)
            {
                CalculateMonthCharges(month, numPayments);
                totalInterestPaid += monthInterest;
            }
        }
        //Return information about the loan
        public override string ToString()
        {
            return "\nLoan Amount: " + loanAmount.ToString("C") +
                   "\nInterest Rate: " + rate +
                   "\nNumber of Years for Loan: " + (numPayments / 12) +
                   "\nMonthly payment: " + paymentAmount.ToString("C");
        }
    }
}