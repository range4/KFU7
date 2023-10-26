using System;
namespace Labwork
{
    public enum AccountType
    {
        Current,
        Savings
    }



    public class Bank
    {
        protected int AccountNumber;
        protected decimal Balance;
        protected AccountType AccountType;

        public Bank(int accountNumber, decimal balance, AccountType accountType)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            AccountType = accountType;
        }

        public int GetAccountNumber()
        {
            return AccountNumber;
        }

        public void GetBalance()
        {
            Console.WriteLine($"Ваш баланс - {Balance}");
        }

        public AccountType GetAccountType()
        {
            return AccountType;
        }

        public void SetAccountType(AccountType accountType)
        {
            AccountType = accountType;
        }

        public override string ToString()
        {
            return $"AccountNumber - {AccountNumber}, Balance - {Balance}, AccountType - {AccountType}";
        }

        public void WithDraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Не достаточно средств для снятия введенной суммы :(");
            }
            else
            {
                Balance -= amount;
            }
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Transfer(Bank account , decimal amount, Bank account1)
        {
            if (amount > account.Balance)
            {
                Console.WriteLine("Не достаточно средств для перевода введенной суммы :(");
            }
            else
            {
                account.Balance -= amount;
                account1.Balance += amount;
                Console.WriteLine($"Совершен перевод {amount} рублей на счет {account1.AccountNumber}, ваш баланс {account.Balance}, если перевод совершили не вы или возникла ошибка, обратитесь в поддержку по номеру горячей линии +79375975337");
            }
            

        }
    }





    public class GeneratedAccountNumber : Bank
    {


        public GeneratedAccountNumber(decimal balance, AccountType accountType) : base(GenerateAccountNumber(), balance, accountType)
        {
        }

        private static int GenerateAccountNumber()
        {
            Random rnd = new Random();
            int accountNumber = rnd.Next(1, 1000);
            return accountNumber;
        }
    }
}


