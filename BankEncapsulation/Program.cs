namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();

            Console.WriteLine("Please enter your deposit amount:");
            var amount = double.Parse(Console.ReadLine());

            myAccount.Deposit(amount);

            Console.WriteLine("New balance:");
            Console.WriteLine(myAccount.GetBalance());
        }
    }
}
