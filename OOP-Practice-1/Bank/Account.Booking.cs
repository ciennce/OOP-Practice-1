using OOP_Practice_1.Gui;
namespace OOP_Practice_1.Bank
{
    public partial class Account
    {
        public void Payout()
        {
            Console.WriteLine("How much would you like to payout?");
            var payoutBalance = Convert.ToInt32(Console.ReadLine());

            if (payoutBalance > Balance)
            {
                Console.Clear();
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                Console.Clear();
                Balance -= payoutBalance;
                Console.WriteLine($"Your new balance is {Balance}$");
            }

            GUI.AwaitEnter();

        }

        public void Deposit()
        {
            Console.WriteLine("How much would you like to deposit?:");

            if (!decimal.TryParse(Console.ReadLine(), out var depositBalance))
            {
                Console.WriteLine("Ungültige Eingabe. Es sind nur Zahlen erlaubt!");
                GUI.AwaitEnter();
                return;
            }

            if (depositBalance < 0)
            {
                Console.Clear();
                Console.WriteLine("Invalid amount.");
            }
            else
            {
                Console.Clear();
                Balance += depositBalance;
                Console.WriteLine($"{depositBalance}$ has been deposited! Your new balance is {Balance}");
            }
            GUI.AwaitEnter();
        }
    }
}
