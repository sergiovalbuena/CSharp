using System;
namespace RealEstateApp
{
    public class RealEstateInvestment
    {
        private string streetAddress;
        private int yearBuilt;
        private double purchasePrice;
        private double monthlyExpense;
        private double incomeFromRent;

        //ReadOnly Property
        public string StreetAddress
        {
            get { return streetAddress; }
        }
        public double YearBuilt
        {
            get { return yearBuilt; }
        }
        public double PurchasePrice
        {
            get { return purchasePrice; }
        }

        //Property acting as mutator and accessor
        public double MonthlyExpense
        {
            set { monthlyExpense = value; }
            get { return monthlyExpense; }
        }
        public double IncomeFromRent
        {
            set { incomeFromRent = value; }
            get { return incomeFromRent; }
        }

        //Defaul constructor
        public RealEstateInvestment()
        {
        }
        //Three parameters constructor with address  listed first
        public RealEstateInvestment(string address, int year, double price)
        {
            streetAddress = address;
            yearBuilt = year;
            purchasePrice = price;
        }
        //Two paramenters constructor
        public RealEstateInvestment(string address, double price)
        {
            streetAddress = address;
            purchasePrice = price;
        }
        //Two parametners constructor price first
        public RealEstateInvestment(double price, string address)
        {
            purchasePrice = price;
            streetAddress = address;
        }
        //Three parameters constructor with year listed first
        public RealEstateInvestment(int year, double price, string address)
        {
            yearBuilt = year;
            purchasePrice = price;
            streetAddress = address;
        }

        //returns the earings for a given month
        public double DeterimineMonthlyEarnings()
        {
            return incomeFromRent - monthlyExpense;
        }
        public override string ToString()
        {
            return "Location :" + streetAddress +
                //"\nYear Built: " + yearBuilt +
                //Year omitted - A constructor is
                //provided without year an Year os read only
                "\nPurchase Price :" +
                purchasePrice.ToString("C") +
                "\nMonthly Income :" + monthlyExpense.ToString("C") +
                "\nIncome from Rent :" + incomeFromRent.ToString("C") +
                "\nMonthly Earnings :" + DeterimineMonthlyEarnings().ToString("C");
        }

    }
}
