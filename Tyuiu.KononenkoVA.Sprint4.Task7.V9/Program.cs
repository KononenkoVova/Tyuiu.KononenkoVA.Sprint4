using System;
using Tyuiu.KononenkoVA.Sprint4.Task7.V9.Lib;

namespace Tyuiu.KononenkoVA.Sprint4.Task7.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int n = 3; 
            int m = 3; 
            string value = "864299753";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Кононенко Владимир Андреевич | ИСПБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"864299753\". Преобразуйте ее в       *");
            Console.WriteLine("* матрицу 3 на 3 и подсчитайте количество четных чисел.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine($"* n = {n}, m = {m}                                                          *");
            Console.WriteLine($"* Строка: {value}                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");

            int result = ds.Calculate(n, m, value);
            Console.WriteLine($"* Количество четных чисел в матрице: {result}                              *");

            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* МАТРИЦА 3x3:                                                            *");
            int[,] matrix = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("* ");
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    Console.Write($"{matrix[i, j]} ");
                    index++;
                }
                Console.WriteLine("                                                         *");
            }
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}