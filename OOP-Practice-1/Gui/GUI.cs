using OOP_Practice_1.Bank;
namespace OOP_Practice_1.Gui
{
    class GUI
    {
        BankDatabase db = new BankDatabase();
        public void Run()
        {
            while (true)
            {
                char key = GetMenuInput();
                switch (key)
                {
                    case '1':
                        Console.Clear();
                        Account account = db.CreateAccount();
                        break;

                    case '2':
                        Console.Clear();
                        Account? found = db.CheckUser();
                        found?.Deposit();
                        break;

                    case '3':
                        Console.Clear();
                        Account? found1 = db.CheckUser();
                        found1?.Payout();
                        break;

                    case '4':
                        Console.Clear();
                        db.ShowBalance();
                        break;

                    case '5':
                        Console.Clear();
                        db.ShowAllAccounts();
                        break;

                    case '6':
                        break;
                }
            }
        }

        private char GetMenuInput()
        {
            Console.Clear();
            Console.WriteLine("[1] Create Account.");
            Console.WriteLine("[2] Deposit.");
            Console.WriteLine("[3] Payout.");
            Console.WriteLine("[4] Show Balance");
            Console.WriteLine("[5] Show All Accounts.");
            Console.WriteLine("[6] Quit.");
            return Console.ReadKey(true).KeyChar;
        }

        public static void AwaitEnter()
        {
            Console.WriteLine("Press [Enter] to continue.");
            Console.ReadLine();
        }
    }
}
