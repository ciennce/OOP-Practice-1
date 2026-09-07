using System.Security.Cryptography.X509Certificates;

namespace OOP_Practice_1
{
    class BankDatabase
    {
        public class AccountDatabase()
        {
            public int IbanDatabase { get; set; }
        }

        List<AccountDatabase> Database = new List<AccountDatabase>();

        public int IbanDatabase { get; set; }

        public Account CreateAccount()
        {
            Console.WriteLine("Account name:");
            string name = Console.ReadLine() ?? "";
            string iban = IbanGenerator(new Random());
            Console.WriteLine($"Account Iban is: {iban}");
            return new Account(name, iban, 0);
        }

        private static string IbanGenerator(Random random)
        {
            
            int digitCode = random.Next(99);
            int bankIdentifierCode = random.Next(99999);
            int branchCode = random.Next(99999);
            int accountNumber = random.Next(9999999);
            return $"DE{digitCode} {bankIdentifierCode} {branchCode} {accountNumber}";

        }
    }
}
