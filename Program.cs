using System;
namespace project
{
     class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Гирман Денис");
            /* Task 2
            Console.WriteLine("Денис Гирман");
            Console.WriteLine("Введіть бажану к-ть хвилин. Ціле число");
            int minutes = int.Parse(Console.ReadLine() ?? "0");

            int hour = minutes / 60;
            int remaining_minutes = minutes % 60;
            Console.WriteLine($"{hour}год : {remaining_minutes}хв"); */
            /* Task 3
            Console.WriteLine("Введіть к-ть булочок");
            int n = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Введіть к-ть гривень");
            int x = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Введіть к-ть копійок");
            int y = int.Parse(Console.ReadLine()?? "0");
            int price_per_bun = (x * 100) + y;
            int total_amount = n * price_per_bun;
            int result_uah = total_amount / 100;
            int result_kop = total_amount % 100;
            Console.WriteLine($"За {n} булочок необхідно заплатити {result_uah} гривень {result_kop} копійок");

            */        
            /* Task 4
            Console.WriteLine("Гирман Денис");
            Console.WriteLine("Введіть к-ть комп. в першому класі");
            int C1 = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Введіть к-ть комп. в другому класі");
            int C2 = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"компʼютерів у 1 класі у вересні - {C1}. Компʼютерів у 2 класі у вересні - {C2}.");
            (C1,C2) = (C2, C1);
            Console.WriteLine($"компʼютерів у 1 класі у жовтні - {C1}. Компʼютерів у 2 класі у жовтні - {C2}.");
            C1 += 4;
            C2 -= 1;
            Console.WriteLine($"компʼютерів у 1 класі у грудні - {C1}. Компʼютерів у 2 класі у грудні - {C2 }.");*/
            /* Task 5
            Console.WriteLine("Гирман Денис");
            int a = int.Parse(Console.ReadLine() ?? "0");
            int b = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"a = {a}, b = {b}");
            (a, b) = (b, a);
            Console.WriteLine($"a = {a}, b = {b}"); */
            /* Task 6 

            Console.WriteLine("Гирман Денис");
            Console.WriteLine("Введіть к-ть хвилин з початку доби:");
            int minutes_user = int.Parse(Console.ReadLine() ?? "0");
            int hours = minutes_user / 60;
            int minutes = minutes_user % 60;
            if (minutes_user >= 1440)
            {
                int days = minutes_user / 1440;
                hours = (minutes_user % 1440) / 60;
                Console.WriteLine($"Годинник показує {days} днів, {hours} годин : {minutes} хвилин з початку доби.");
            }
            else
            {
                Console.WriteLine($"Годинник показує {hours} годин : {minutes} хвилин з початку доби.");
            }*/
            /* Task 7
            Console.WriteLine("Введіть ціле чотирьохзначне число:");
            int number_user = int.Parse(Console.ReadLine() ?? "0");
            int digit1 = number_user / 1000;
            int digit2 = (number_user / 100) % 10;
            int digit3 = (number_user / 10) % 10;
            Console.WriteLine($"одиниці: {digit1}");
            Console.WriteLine($"десятки: {digit2}");
            Console.WriteLine($"сотні: {digit3}");    
            Console.WriteLine($"сума цифр - {digit1 + digit2 + digit3}");*/
            /* Task 8
            int a = int.Parse(Console.ReadLine() ?? "0");
            int[] money_nominals = { 50, 20, 10, 5, 1 };
            for (int i = 0; i < money_nominals.Length; i++)
            {
                int count = a / money_nominals[i];
                Console.WriteLine(count);
                a = a % money_nominals[i];
                Console.WriteLine(a);
                Console.WriteLine($"{money_nominals[i]} грн - {count} шт");
            } */   
        }
    }
}