using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day05_part02
{
    internal class BankAccount
    {
        private string accountHolder; 
        private double balance; 
        public int accountNumber;
       // public int counter
        private static int totalAccounts = 0;
        private static double totalBankBalance = 0.0;


        public BankAccount(string name, double initialBalance)
        {
            accountHolder = name;
            balance = initialBalance;
            totalAccounts++;
            accountNumber = totalAccounts;
            totalBankBalance += balance;

        }

        public static void PrintBankSummary()
        {
            Console.WriteLine($"Total Accounts: {totalAccounts}, Total Bank Balance:{totalBankBalance} $Y");
        }

        public static double GetAverageBalance()
        {
            if (totalBankBalance != 0.0)
            {
                return totalBankBalance / totalAccounts;
            }
            else 
                { return 0.0; }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("enter correct amount \n");
            }

        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("you don't have enough amount\n");
            }
        }

        public static BankAccount operator+(BankAccount a, BankAccount b)
        {
            string name = $"{a.accountHolder}  & {b.accountHolder}" ;
            double balance = a.balance+b.balance;
            BankAccount bank = new BankAccount(name, balance);
            totalBankBalance-=balance;
            return bank;
        }

        public static bool operator<(BankAccount a, BankAccount b)
        {
            return (a.balance < b.balance);
        }
        public static bool operator >(BankAccount a, BankAccount b)
        {
            return (a.balance > b.balance);
        }

        public static bool operator==(BankAccount a, BankAccount b)
        {
            return (a.accountNumber == b.accountNumber);
        }

        public static bool operator !=(BankAccount a, BankAccount b)
        {
            return (a.accountNumber == b.accountNumber);
        }


    }
}
