using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqToObjectsTasks
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Задача 15: Количество элементов ===");
            Task15_Count();
            Console.WriteLine();
            static void Task15_Count()
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                var totalCount = numbers.Count();
                Console.WriteLine($"Исходный массив: {string.Join(", ", numbers)}");
                Console.WriteLine($"Общее количество элементов: {totalCount}");
            }

        }
    }
}/*5