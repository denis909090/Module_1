using System;

namespace Project
{
    class Base_tasks_5
    {
        public static void task_2()
        {
            Console.WriteLine("Введіть перше число:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 % number2 == 0)
            {
                Console.WriteLine("Число " + number1 + " є кратним числу " + number2);
            }
            else
            {
                Console.WriteLine("Число " + number1 + " не є кратним числу " + number2);
            }
        }
    }
}