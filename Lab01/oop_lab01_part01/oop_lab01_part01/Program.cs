namespace oop_lab01_part01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AccountBank acc1 = new AccountBank();

            acc1.SetAccountNumber("1234567");
            acc1.SetAccountHolderName("Manar");
            acc1.Deposit(1000);
            acc1.Withdraw(500);
            acc1.GetBalance();
            acc1.DeactivateAccount();
            acc1.ActivateAccount();
            acc1.CheckActive();
            acc1.DisplayAccountInfo();  

            AccountBank acc2 = new AccountBank();

            acc2.SetAccountNumber("12222225");
            acc2.SetAccountHolderName("Nada");
            acc2.Deposit(2000);
            acc2.Withdraw(3000);
            acc2.GetBalance();
            acc2.DeactivateAccount();
            acc2.ActivateAccount();
            acc2.CheckActive();
            acc2.DisplayAccountInfo();
               




        }
    }
}
