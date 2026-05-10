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
            Console.WriteLine("Введіть пору року українською:");
            string season = Console.ReadLine();

            string result = Base_tasks_5.task_4(season);
            Console.WriteLine(result);
        }
    }
}
