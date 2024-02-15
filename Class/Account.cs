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

        public bool Withdraw(double withdrawAmount)
        {
            // Calculate the maximum allowed credit (Credit * -1)
            double maxAllowedCredit = Credit * -1;

            // Check if the balance is insufficient
            if (Balance - withdrawAmount < maxAllowedCredit)
            {
                Console.WriteLine("Insufficient Balance.");
                return false;
            }

            // Update the balance
            Balance -= withdrawAmount;

            // If the balance is negative, update the credit
            if (Balance < 0)
            {
                Credit = Math.Max(0, Credit + Balance);
            }

            Console.WriteLine($"The current account balance of {Name} is: ${Balance},00");
            Console.WriteLine($"The current credit of {Name} is: ${Credit},00");

            return true;
        }

        public void Deposit(double depositAmount) 
        {
            Balance += depositAmount;

            Console.WriteLine($"The current account balance of {Name} is: ${Balance},00");
        }

        public void Transfer(double transferAmount, Account destinationAccount)
        {
            if(Withdraw(transferAmount))
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