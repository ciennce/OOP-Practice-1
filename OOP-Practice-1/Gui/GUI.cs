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
                Console.Clear();
                switch (key)
                {
                    case '1': db.CreateAccount(); break;
                    case '2': db.CheckUser()?.Deposit(); break;
                    case '3': db.CheckUser()?.Payout(); break;
                    case '4': db.ShowBalance(); break;
                    case '5': db.ShowAllAccounts(); break;
                    case '6': break;
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
