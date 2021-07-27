using System;

namespace ClassesExercise
{
        class Program
    {
        static void Main(string[] args)
        {
            Car instance1 = new Car() { Make = "Jeep", Model = "Wrangler", Year = 2007 };
            Console.WriteLine($"{instance1.Make} {instance1.Model} {instance1.Year}");
        }
    }
}
