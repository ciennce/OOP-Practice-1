namespace OOP_Practice_1.Bank
{
    public partial class Account
    {
        public string Name { get; }

        public string Iban { get; }

        public decimal Balance { get; private set; }

        public Account(string name, string iban, int balance)
        {
            this.Name = name;
            this.Iban = iban;
            this.Balance = balance;
        }
    }
}
