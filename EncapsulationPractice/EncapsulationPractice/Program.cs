using System;

namespace EncapsulationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount user = new BankAccount();
            bool yes = true;
            while (yes)
            {
                Console.WriteLine("How much would you like to deposit?");
                user.Deposit(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine($"New balance: {user.GetBalance()}");
                Console.WriteLine("Would you like to deposit more?(y/n)");
                if(Console.ReadLine() != "y")
                {
                    yes = false;
                }
            }
        }
    }
}
