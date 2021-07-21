using System;

namespace MethodsExercise3
{
    class Program
    {
        public static void uno()
        { 
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void dos()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        public static void tres()
        {
            int a;
            int b;
            Console.WriteLine("Enter an integer");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another integer");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine((a == b) ? $"Those integers are equal" : $"{a} and {b} are not equal");
        }
        public static void cuatro()
        {
            int a;
            Console.WriteLine("Enter an integer");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine((a % 2 == 0) ? $"{a} is Even" : $"{a} is Odd");
        }
        public static void cinco()
        {
            int a;
            Console.WriteLine("Enter an integer");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine((a > 0) ? $"{a} is Positive" : $"{a} is Negative");
        }
        public static void seis()
        {
            int age;
            Console.WriteLine("How many years old are you?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine((age >= 35) ? "You can vote" : "You can't vote");
        }
        public static void inRange()
        {
            int a;
            Console.WriteLine("Enter an integer");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine((a >= -10 && a <= 10) ? $"{a} is in the range of -10 and 10" : $"{a} is not in the range of -10 and 10");
        }
        public static void multTable()
        {
            int product;
            int a;
            Console.WriteLine("Enter an integer");
            a = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 12; i++)
            {
                product = a * i;
                Console.WriteLine($"{a} times {i} is {product}");
            }
        }
        static void Main(string[] args)
        {
            uno();
            dos();
            tres();
            cuatro();
            cinco();
            seis();
            inRange();
            multTable();



            


        }
    }
}
