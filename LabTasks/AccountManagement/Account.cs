using System;

namespace AccountManagement
{
    public class Account
    {
        private string accName;
        private int acid;
        private double balance;

        public Account()
        {
            balance = 0;
        }
        
        public Account(int id)
        {
            acid = id;
            balance = 0;
        }

        public Account(int id, double bal)
        {
            acid = id;
            balance = bal;
        }

        public Account(int id, string name, double bal)
        {
            acid = id;
            accName = name;
            balance = bal;
        }

        public string getAccName()
        {
            return accName;
        }

        public int getAcid()
        {
            return acid;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setAccName(string name)
        {
            accName = name;
        }
        public void setAcId(int id)
        {
            acid = id;
        }
        public void setBalance(double bal)
        {
            balance = bal;
        }

        public bool Deposit(double amount)
        {
            setBalance(getBalance() + amount);
            return true;
        }
        public bool Withdraw(double amount)
        {
            if (getBalance() < amount)
            {
                return false;
            }
            setBalance(getBalance() - amount);
            return true;
        }
        public bool Transfer(double amount, Account receiver)
        {
            if (amount > getBalance())
            {
                return false;
            }
            
            setBalance(getBalance() - amount);
            receiver.setBalance(receiver.getBalance() + amount);
            return true;
        }
        public void ShowDetail()
        {
            Console.WriteLine($"Detail (Acc No: {getAcid()})");
            Console.WriteLine($"Account Name: {getAccName()}\nBalance: {getBalance()}");
        }
    }
}