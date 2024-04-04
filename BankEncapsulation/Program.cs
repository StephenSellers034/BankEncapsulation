namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            account1.Deposit(550.34);
            account1.GetBalance();

        }
    }
}
