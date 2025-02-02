﻿using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество секунд для обратного отсчета:");
        int seconds;
        if (int.TryParse(Console.ReadLine(), out seconds))
        {
            for (int i = seconds; i >= 0; i--)
            {
                Console.WriteLine($"Осталось секунд: {i}");
                Thread.Sleep(1000); // Приостанавливаем выполнение программы на 1 секунду
            }
            Console.WriteLine("Обратный отсчет завершен!");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }
    }
}
