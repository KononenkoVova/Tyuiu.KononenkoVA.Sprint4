using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KononenkoVA.Sprint4.Task6.V1.Lib
{
    public class DataService : ISprint4Task6V1
    {
        public int Calculate(string[] array)
        {
            int count = 0;
            foreach (string item in array)
            {
                if (item.Length > 6)
                {
                    count++;
                }
            }
            return count;
        }
    }
}