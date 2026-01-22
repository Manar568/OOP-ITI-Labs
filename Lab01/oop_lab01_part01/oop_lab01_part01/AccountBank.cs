using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab01_part01
{
    internal class AccountBank
    {
        private string AccountNumber;
        private string AccountHolderName="UnDefined";
        private bool IsActive=true;
        private double Balance=0;


        public void SetAccountNumber(string number)
        {

            if (number.Length == 8)
            {
                AccountNumber = number;
            }
            else
            {
                Console.WriteLine("the number shouls be 8 digits\n");

            }

        }


        public void SetAccountHolderName(string name) {

            if (name != null)
            {
                AccountHolderName = name;
            }
            else
            {
                Console.WriteLine("enter the name\n");
            }
        
        }

        public string GetAccountHolderName()
        {
            return $" the name is :{AccountHolderName}\n";
        }
        public double GetBalance()
        {
           return Balance;
        }
        public bool CheckActive()
        {
            return IsActive;

        }
      public void  Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("enter correct amount \n");
            }

        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance) {
            Balance -= amount;
            }
            else
            {
                Console.WriteLine("you don't have enough amount\n");
            }
        }

        public void ActivateAccount()
        {
            IsActive = true;
        }

        public void DeactivateAccount() { 
        IsActive=false;
        }

        public void DisplayAccountInfo()
        { 
            Console.WriteLine($"Account Number : {AccountNumber}\n Holder : {AccountHolderName}\n Balance : {Balance} $\n Status: {CheckActive()}\n");





        }

    }
}
