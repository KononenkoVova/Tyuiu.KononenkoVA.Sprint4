using System;
using Tyuiu.KononenkoVA.Sprint4.Task2.V8.Lib;

namespace Tyuiu.KononenkoVA.Sprint4.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Кононенко Владимир Андреевич | ИСПБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов, заполненный        *");
            Console.WriteLine("* случайными числами в диапазоне от 2 до 7. Подсчитать сумму нечетных    *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Random random = new Random();
            int[] array = new int[11];

            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(2, 8);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine("Сумма нечетных элементов массива = " + result);

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}