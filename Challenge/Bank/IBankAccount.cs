using System;

namespace Bank
{
    public interface IBankAccount
    {
        bool DepositMoney(decimal amount);
        bool WithDrawMoney(decimal amount);
        bool TransferMoney(IBankAccount otherAccount, decimal amount);

        Decimal Balance { get; }
    }

    public class CheckingAccount : IBankAccount
    {
        public decimal balance;

        public CheckingAccount(int startingBalance)
        {
            balance = startingBalance;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
        }

        public bool DepositMoney(decimal amount)
        {
            balance += amount;
            return true;    
        }

        public bool TransferMoney(IBankAccount otherAccount, decimal amount)
        {
            decimal actualAmount = amount * 1.10m;
            this.WithDrawMoney(amount);
            otherAccount.DepositMoney(amount);
            return true;
        }

        public bool WithDrawMoney(decimal amount)
        {
            balance -= amount;
            return true;
        }
    }

    public class SavingsAccount : IBankAccount
    {
        private decimal balance;

        public SavingsAccount(int startingBalance)
        {
            balance = startingBalance;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
        }

        public bool DepositMoney(decimal amount)
        {
            balance += amount;
            return true;
        }

        public bool TransferMoney(IBankAccount otherAccount, decimal amount)
        {
            balance -= amount;
                return true;
        }

        public bool WithDrawMoney(decimal amount)
        {
            var fee = CalculateFee(amount, WithDrawType.Transfer);
            if (amount < balance)
            {
                balance -= (amount * 1.05m);
                return true;
            }
            return false;
        }

        private object CalculateFee(decimal amount, object transfer)
        {
            throw new NotImplementedException();
        }
    }

    class WithDrawType
    {
        public static object Transfer { get; internal set; }
    }
}