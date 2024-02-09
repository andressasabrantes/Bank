using Bank.Class;
using Bank.Enum;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account(AccountType.Individual, 50, 50, "Andressa");

            Console.WriteLine(myAccount);
        }
    }
}