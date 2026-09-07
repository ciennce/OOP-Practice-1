using OOP_Practice_1.Gui;
namespace OOP_Practice_1.Bank
{
    class Account
    {
        public string Name { get; set; }
        public string Iban { get; set; }
        public int Balance { get; private set; }

        public Account(string name, string iban, int balance)
        {
            this.Name = name;
            this.Iban = iban;
            this.Balance = balance;
        }

        public void Payout()
        {
            Console.WriteLine("How much would you like to payout?");
            int payoutBalance = Convert.ToInt32(Console.ReadLine());

            if (payoutBalance > Balance)
            {
                Console.Clear();
                Console.WriteLine("Insufficient funds.");
            }else
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
            int depositBalance = Convert.ToInt32(Console.ReadLine());
            
            if (depositBalance < 0)
            {
                Console.Clear();
                Console.WriteLine("Invalid amount.");
            } else
            {
                Console.Clear();
                Balance += depositBalance;
                Console.WriteLine($"{depositBalance}$ has been deposited! Your new balance is {Balance}");
            }
            GUI.AwaitEnter();
        }
    }
}
