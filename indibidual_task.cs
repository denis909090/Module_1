using System;
using System.Runtime.InteropServices.Marshalling;

namespace Project
{
    class IndividualTask_3
    {
        public static void variant_3()
        {
            /*Написати програму, яка вилучає введений з клавіатури символьний рядок (символ)
із символьного рядка. Символьний рядок та символи для вилучення вводяться з клавіатури під час
роботи програми. Вивести результати перетворень.*/
            Console.Write("Введіть рядок: ");
            string inputString = Console.ReadLine() ?? string.Empty;
            Console.Write("Введіть символ для вилучення: ");
            string removeChar = Console.ReadLine() ?? string.Empty;
            string resultString = inputString.Replace(removeChar, "");
            Console.WriteLine($"Результат: {resultString}");
        }
    }
}