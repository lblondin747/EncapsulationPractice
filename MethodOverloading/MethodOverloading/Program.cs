using System;

namespace MethodOverloading
{
    class Program
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static decimal add(decimal a, decimal b)
        {
            return a + b;
        }
        public static string add(bool money,int a, int b)
        {
            if (money)
            {
                if (a + b == 1)
                {
                    return $"{a + b} dollar";
                }
                else
                    return $"{a + b} dollars";
            }
            else
                return $"{a + b}";

        }
        static void Main(string[] args)
        {
            Console.WriteLine(add(1, 5));
            Console.WriteLine(add(1.33m, 1.567m));
            Console.WriteLine(add(true, 2, 5));
            
        }
    }
}
