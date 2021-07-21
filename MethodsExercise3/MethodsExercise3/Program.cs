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
        public static string tres(int a, int b)
        {
            return (a == b) ? "equal" : "not equal";
        }
        public static string cuatro(int a)
        {
            return (a % 2 == 0) ? "Even" : "Odd";
        }
        public static string cinco(int a)
        {
            return (a > 0) ? "Positive" : "Negative";
        }
        public static string seis(int a)
        {
            return (a >= 35) ? "You can vote" : "You can't vote";
        }
        public static bool inRange(int a)
        {
            return (a >= -10 && a <= 10) ? true : false;
        }
        public static void multTable(int a)
        {
            int product;
            for(int i = 1; i <= 12; i++)
            {
                product = a * i;
                Console.WriteLine($"{a} times {i} is {product}");
            }
        }
        static void Main(string[] args)
        {
            //uno();
            //dos();
            //Console.WriteLine(tres(9,10));
            //Console.WriteLine(cuatro(21));
            //Console.WriteLine(cinco(30));
            //Console.WriteLine(seis(35));
            //Console.WriteLine(inRange(5));
            //multTable(12);



            


        }
    }
}
