using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Project
{
    class higher_dif_tasks
    {
        /*public static void task_6()
        {
            Console.WriteLine("Гирман Денис");

            Console.Write("Введіть першу сторону трикутника: ");
            double a = Math.Abs(double.Parse(Console.ReadLine() ?? string.Empty));
            Console.Write("Введіть другу сторону трикутника: ");
            double b = Math.Abs(double.Parse(Console.ReadLine() ?? string.Empty));
            Console.Write("Введіть третю сторону трикутника: ");
            double c = Math.Abs(double.Parse(Console.ReadLine() ?? string.Empty));
            if (a * a + b * b < c * c || a * a + c * c < b * b || b * b + c * c < a * a)
            {
                Console.WriteLine("Тупокутний трикутник.");
            }
            else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            {
                Console.WriteLine("Прямокутний трикутник.");
            }
            else if (a * a + b * b > c * c && a * a + c * c > b * b && b * b + c * c > a * a)
            {
                Console.WriteLine("Гострокутний трикутник.");
            }
            else
            {
                Console.WriteLine("Трикутник з такими сторонами не існує.");
            }
        }*/
        public static void task_8()
        {
            Console.WriteLine("Гирман Денис");
            int road = 109;
            Console.WriteLine("Введіть кількість годин: ");
            int hours = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Введіть швидкість мотоцикліста: ");
            int speed = int.Parse(Console.ReadLine() ?? string.Empty);
            int result = (speed * hours) % road;

            if (result < 0)
            {
                result += 109;
            }

            Console.WriteLine(result);
        }
    }
}
