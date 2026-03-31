using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;

namespace Project
{
    class base_tasks_3
    {
        /*public static void task_4()
        {
            Console.WriteLine("Скільки чисел ви хочете додати в масив: ");
            int user_input = int.Parse(Console.ReadLine() ?? string.Empty); // отримуємо кількість чисел, які юзер хоче ввести
            int[] numbers = new int[user_input]; // створюємо масив з розміром, який вказав юзер
            for (int i = 0; i < user_input; i++)
            {
                Console.Write($"Введіть число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine() ?? string.Empty);
            }
            Console.WriteLine($"Ваш масив чисел: {string.Join(", ", numbers)}");
            int neg_num = 0; // змінна для підрахунку відʼємних чисел
            int pos_num = 0; // змінна для підрахунку додатніх чисел
            int sum = 0; // змінна для підрахунку суми всіх чисел
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i]; // додаємо кожне число до суми
                if (numbers[i] < 0)
                {
                    neg_num++;
                }
                else if (numbers[i] > 0)
                {
                    pos_num++;
                }
                else
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine($"Кількість від'ємних чисел: {neg_num}");
            Console.WriteLine($"Кількість додатніх чисел: {pos_num}");
            Console.WriteLine($"Сума всіх чисел: {sum}");
        }*/
        /*public static void task_5()
        {
            double start = -5;
            double end = 5;
            double step = 0.4;

            for (double x = start; x <= end; x += step)
            {
                double y = Math.Abs(x - 3) + Math.Abs(x + 2);
                Console.WriteLine($"x: {x}, y: {y}");
            }
        }*/
        public static void task_6()
        {
            Console.Write("Введіть число a: ");
            int a = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.Write("Введіть число b: ");
            int b = int.Parse(Console.ReadLine() ?? string.Empty);
            int[] numbers = new int[0];
            for (int i = a; i > b; i--)
            {
                numbers = numbers.Append(i).ToArray(); 
                Console.WriteLine(i);
            }
            Console.WriteLine("Масив чисел:");
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine($"Кількість чисел: {numbers.Length}");
        }
    }
}
