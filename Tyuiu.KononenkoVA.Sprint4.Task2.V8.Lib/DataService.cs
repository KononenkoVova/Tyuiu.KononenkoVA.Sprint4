using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KononenkoVA.Sprint4.Task2.V8.Lib
{
    public class DataService
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}