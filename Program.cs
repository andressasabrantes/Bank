using System.Net.Http.Headers;
using Bank.Class;
using Bank.Enum;

namespace Bank
{
    class Program
    {

        static List<Account> accountList = new List<Account>();

        static void Main(string[] args)
        {
            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch(userOption)
                {
                    case "1":
                        AccountList();
                        break;
                    case "2":
                        AddAccount();
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
        }

        private static void AddAccount()
        {
            Console.WriteLine("Add new account:");

            Console.Write("Press 1 for Legal Person or 2 for Individual Account: ");
            int userAccountType = int.Parse(Console.ReadLine());

            Console.Write("Enter the Client's Name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter the initial balance: ");
            double userInitialBalance = double.Parse(Console.ReadLine());

            Console.Write("Enter the credit: ");
            double userCredit = double.Parse(Console.ReadLine());

            Account newAccount = new Account((AccountType)userAccountType, 
                                            userInitialBalance, 
                                            userCredit,
                                            userName);

            accountList.Add(newAccount);
        }

        private static void AccountList()
        {
            Console.WriteLine("List of the accounts:");
            
            if(accountList.Count == 0) 
            {
                Console.WriteLine("No account registered.");
                return;
            }
            
            for (int i = 0; i < accountList.Count; i++) 
            {
                Account account = accountList[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(account);
            }
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