using Tyuiu.KononenkoVA.Sprint4.Task6.V1.Lib;

namespace Tyuiu.KononenkoVA.Sprint4.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string[] array = new string[] { "Яблоко", "Вишня", "Дыня", "Груша", "Мандарин", "Виноград" };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Кононенко Владимир Андреевич | ИСПБ-25-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан массив строк: [\"Яблоко\", \"Вишня\", \"Дыня\", \"Груша\", \"Мандарин\", \"Виноград\"] *");
            Console.WriteLine("* Подсчитать количество элементов, длина которых больше 6.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.Write("* Массив: [");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"\"{array[i]}\"");
                if (i < array.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");

            int result = ds.Calculate(array);
            Console.WriteLine($"* Количество элементов длиной больше 6: {result}                            *");

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}