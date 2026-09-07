namespace OOP_Practice_1
{
    class Account
    {
        public string Name { get; set; }
        public string Iban { get; set; }
        protected int Balance { get; set; }

        public Account(string Name, string Iban, int Balance)
        {
            this.Name = Name;
            this.Iban = Iban;
            this.Balance = Balance;
        }

        public void Payout(string Name, string Iban, int PayoutBalance)
        {
            if(Name == this.Name || Iban == this.Iban)
            {
                if (PayoutBalance > this.Balance)
                {
                    Console.WriteLine("Insufficient funds.");
                }else
                {
                    this.Balance -= PayoutBalance;
                }
            }else
            {
                Console.WriteLine("This Account or Iban does not exit. Please try again.");
            }
        }

        public void Deposti(string Name, string Iban, int DeopositBalance)
        {
            if (Name == this.Name || Iban == this.Iban)
            {
                if (DeopositBalance < 0)
                {
                    Console.WriteLine("Invalid amount.");
                }else
                {
                    this.Balance += DeopositBalance;
                }
            }else
            {
                Console.WriteLine("This Account or Iban does not exit. Please try again.");
            }
        }
    }
}
