using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KononenkoVA.Sprint4.Task3.V5.Lib
{
    public class DataService : ISprint4Task3V5
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;
            int rows = array.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                sum += array[i, 0];
            }

            return sum;
        }
    }
}