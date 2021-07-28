using System;
namespace EncapsulationPractice
{
    public class BankAccount
    {
        private double balance = 0;
        public BankAccount()
        {
        }
        public void Deposit(double d)
        {
            balance += d;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}
