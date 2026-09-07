using OOP_Practice_1;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace OOP_PRACTICE
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int keyStroke = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
            switch (keyStroke)
            {
                case 1:
                    BankDatabase db = new BankDatabase();
                    Account account = db.CreateAccount();

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4: 
                    Environment.Exit(0);
                    break;
            }

        }
    }
}