using OOP_Practice_1.Gui;

namespace OOP_Practice_1.Bank
{
    class BankDatabase
    {
        public List<Account> Database = new List<Account>();

        public Account CreateAccount()
        {
            Console.WriteLine("Account name:");
            string name = Console.ReadLine() ?? "";

            Console.Clear();

            string iban = IbanGenerator(new Random());
            Console.WriteLine($"Account Iban is: {iban}");

            GUI.AwaitEnter();

            Account account = new Account(name, iban, 0);
            Database.Add(account);
            return account;
        }

        public void ShowBalance()
        {
            Console.WriteLine("Iban:");
            string iban = Console.ReadLine() ?? "";
            Account? found = Database.FirstOrDefault(x => x.Iban == iban);
            if (found == null)
            {
                Console.WriteLine("Iban not found.");
            }
            else
            {
                Console.WriteLine($"Balance: {found.Balance}$");
            }
            GUI.AwaitEnter();
        }

        private static string IbanGenerator(Random random)
        {

            int digitCode = random.Next(99);
            int bankIdentifierCode = random.Next(99999);
            int branchCode = random.Next(99999);
            int accountNumber = random.Next(9999999);
            return $"DE{digitCode} {bankIdentifierCode} {branchCode} {accountNumber}";

        }

        public Account? CheckUser()
        {
            if (Database.Count == 0) //List check
            {
                Console.WriteLine("Create an account first.");
                return null;
            }
            else
            {
                Console.WriteLine("Iban:");
                string iban = Console.ReadLine() ?? "";

                Account? found = Database.FirstOrDefault(x => x.Iban == iban);
                if (found == null)
                {
                    Console.WriteLine("Iban not found!");
                    return null;
                }
                Console.Clear();
                Console.WriteLine("Iban found!");
                return found;
            }
        }

        public void ShowAllAccounts()
        {
            if (Database.Count == 0) //List check
            {
                Console.WriteLine("Create an account first.");

            }
            else
            {
                foreach (Account item in Database)
                {
                    Console.WriteLine($"Name: {item.Name}, Iban: {item.Iban}, Balance: {item.Balance}$");
                }
            }
            GUI.AwaitEnter();
        }
    }
}
