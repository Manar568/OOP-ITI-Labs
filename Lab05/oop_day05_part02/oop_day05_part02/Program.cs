namespace oop_day05_part02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            BankAccount b1 = new BankAccount("bank1", 100);
            BankAccount b2 = new BankAccount("bank2", 200);
            BankAccount b3 = new BankAccount("bank3", 300);
            BankAccount b4 = new BankAccount("bank4", 400);
            BankAccount b5 = new BankAccount("bank5", 500);
            BankAccount.PrintBankSummary();
            BankAccount.GetAverageBalance();

            Console.WriteLine( BankAccount.GetAverageBalance());

            Console.WriteLine(b2>b1);
            Console.WriteLine(b2 < b1);
            Console.WriteLine(b3.accountNumber);
            Console.WriteLine(b4.accountNumber);
            Console.WriteLine(b3 == b5);

            BankAccount b6 = b1 + b2;

            Console.WriteLine(b6.accountNumber);


            BankAccount.PrintBankSummary();




        }
    }
}
