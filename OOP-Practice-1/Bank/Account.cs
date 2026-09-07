using OOP_Practice_1.Gui;
using System.Xml.Linq;

namespace OOP_Practice_1.Bank
{
    class Account
    {
        public string Name { get; set; }
        public string Iban { get; set; }
        public int Balance { get; set; }

        public Account(string Name, string Iban, int Balance)
        {
            this.Name = Name;
            this.Iban = Iban;
            this.Balance = Balance;
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
