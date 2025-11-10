using Tyuiu.KononenkoVA.Sprint4.Task0.V19.Lib;

namespace Tyuiu.KononenkoVA.Sprint4.Task0.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Кононенко Владимир Андреевич | ИСПБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            Console.WriteLine("Исходный массив: {9, 5, 7, 4, 5, 3, 7, 8, 9, 1}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            int result = ds.GetMultOddArrEl(array); 
            Console.WriteLine($"Произведение нечётных элементов массива = {result}");
            Console.WriteLine("***************************************************************************");
            
            Console.ReadKey();
        }
    }
}