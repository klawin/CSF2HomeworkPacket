using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class CreditCardAccount
    {
        //FIELDS
        private int _accountNumber;
        private decimal _balance;
        private bool _isPastDue;
        private decimal _annualInterestRate;
        private Customer _customerInfo;

        //PROPERTIES
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }
        public Customer CustomerInfo { get; set; }

        //CONSTRUCTORS
        public CreditCardAccount(Customer customerInfo, int accountNumber, decimal balance, decimal annualInterestRate, bool isPastDue)
        {
            CustomerInfo = customerInfo;
            AccountNumber = accountNumber;
            Balance = balance;
            AnnualInterestRate = annualInterestRate;
            IsPastDue = isPastDue;
        }

        public CreditCardAccount()
        {

        }

        //METHODS
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("\nCustomer Info: {0}" +
                "\nAccount Number: {1}" +
                "\nBalance: {2:c}" +
                "\nAnnual Interest Rate: {3}%" +
                "\nPast Due?: {4}", CustomerInfo, AccountNumber, Balance, AnnualInterestRate, IsPastDue ? "YES" : "NO");
        }

    }//end CreditCardAccount
}//end namespace
