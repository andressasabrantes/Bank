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
                        WithDraw();
                        break;
                    case "5":
                        Deposit();
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
            Console.WriteLine("You selected the option >> 2 - ADD A NEW ACCOUNT <<");
            Console.WriteLine();

            Console.WriteLine("To add a new account, please:");

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

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        private static void AccountList()
        {
            Console.WriteLine("You selected the option >> 1 - LIST ALL THE ACCOUNTS <<");
            Console.WriteLine();

            if(accountList.Count == 0) 
            {
                Console.WriteLine("No account registered.");
                return;
            }
            
            Console.WriteLine("List of the accounts:");

            for (int i = 0; i < accountList.Count; i++) 
            {
                Account account = accountList[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(account);
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        private static void WithDraw()
        {
            Console.WriteLine("You selected the option >> 4 - WITHDRAW <<");
            Console.WriteLine();

            Console.Write("Enter the number of the account: ");
            int numberOfTheAccount = int.Parse(Console.ReadLine());

            Console.Write("Enter the amount you want to withdraw: ");
            double withdrawAmount = double.Parse(Console.ReadLine());

            accountList[numberOfTheAccount].WithDraw(withdrawAmount);

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        private static void Deposit()
        {
            Console.WriteLine("You selected the option >> 5 - Deposit <<");
            Console.WriteLine();
            Console.Write("Enter the number of the account: ");

            int numberOfTheAccount = int.Parse(Console.ReadLine());

            Console.Write("Enter the amount you want to make a deposit: ");
            double depositAmount = double.Parse(Console.ReadLine());

            accountList[numberOfTheAccount].Deposit(depositAmount);

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank at your service!");
            Console.WriteLine("How can we help you today?");
            Console.WriteLine();
            Console.WriteLine("Select the option below:");

            Console.WriteLine("1 - List all the accounts");
            Console.WriteLine("2 - Add new account");
            Console.WriteLine("3 - Make a new transfer");
            Console.WriteLine("4 - Withdraw");
            Console.WriteLine("5 - Deposit");
            Console.WriteLine("C - Clean");
            Console.WriteLine("X - Exit");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
    }
}