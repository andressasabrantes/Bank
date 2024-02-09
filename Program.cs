using System.Net.Http.Headers;
using Bank.Class;
using Bank.Enum;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch(userOption)
                {
                    case "1":
                        //AccountsList();
                        break;
                    case "2":
                        //AddAccount();
                        break;
                    case "3":
                        //Transfer();
                        break;
                    case "4":
                        //WithDraw();
                        break;
                    case "5":
                        //Deposit();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                userOption = GetUserOption();
            }

            Console.WriteLine("Thank you for choosing our Bank! See you next time!");
            Console.ReadLine();
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank at your service!");
            Console.WriteLine("How can we help you today?");
            Console.WriteLine("Select the option below:");

            Console.WriteLine("1 - Account's List");
            Console.WriteLine("2 - Add new account");
            Console.WriteLine("3 - Make a new transfer");
            Console.WriteLine("4 - Withdraw");
            Console.WriteLine("C - Clean");
            Console.WriteLine("X - Exit");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
    }
}