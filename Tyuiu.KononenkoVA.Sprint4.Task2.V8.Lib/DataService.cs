using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KononenkoVA.Sprint4.Task2.V8.Lib
{
    public class DataService : ISprint4Task2V8
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