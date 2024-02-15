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

        public bool WithDraw(double withDrawAmount) 
        {
            if (Balance - withDrawAmount < (Credit *-1)) 
            {
                Console.WriteLine("Insufficient Balance.");
                return false;
            }
            
            Balance -= withDrawAmount;

            if (Balance < 0)
            {
                Credit -= withDrawAmount;
            }

            Console.WriteLine($"The current account balance of {Name} is: ${Balance},00");

            return true;
        }

        public void Deposit(double depositAmount) 
        {
            Balance += depositAmount;

            Console.WriteLine($"The current account balance of {Name} is: ${Balance},00");
        }

        public void Transfer(double transferAmount, Account destinationAccount)
        {
            if(WithDraw(transferAmount))
            {
                destinationAccount.Deposit(transferAmount);
            }
        }

        public override string ToString()
        {
            string output = "";
            output += "Account type: " + AccountType + " | ";
            output += "Name: " + Name + " | ";
            output += "Balance: " + Balance + " | ";
            output += "Credit: " + Credit + " | ";
            return output;
        }
    }
}