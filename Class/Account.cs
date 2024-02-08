using Bank.Enum;

namespace Bank.Class
{
    public class Account
    {
        private AccountType AccountType { get; set; }
        private double Balance { get; set; }
        private double Credit { get; set; }
        private string Name { get; set;}

        public Account(AccountType accountType, double balance, double credit, string name) 
        {
            AccountType = accountType;
            Balance = balance;
            Credit = credit;
            Name = name;
        }
    }
}