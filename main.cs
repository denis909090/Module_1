using System;
using Project;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Гирман Денис");
            // Console.WriteLine("Введіть перше число:");
            // int number1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Введіть друге число:");
            // int number2 = int.Parse(Console.ReadLine());
            // Base_tasks_5.task_2(number1, number2);
            // Console.WriteLine("Введіть пору року українською:");
            // string season = Console.ReadLine();

            // string result = Base_tasks_5.task_4(season);
            // Console.WriteLine(result);
            Console.WriteLine("Введіть перше число:");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("До обміну: number1 = " + number1 + ", number2 = " + number2);

            Base_tasks_5.task_5(ref number1, ref number2);

            Console.WriteLine("Після обміну: number1 = " + number1 + ", number2 = " + number2);
        }
    }
}
