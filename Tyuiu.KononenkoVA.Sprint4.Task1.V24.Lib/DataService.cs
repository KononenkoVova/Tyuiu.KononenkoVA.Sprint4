using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KononenkoVA.Sprint4.Task1.V24.Lib
{
    public class DataService : ISprint4Task1V24
    {
        public int Calculate(int[] array)
        {
            int count = 1;
            bool nechet = false;

            foreach (int num in array)
            {
                if (num % 2 != 0) 
                {
                    count *= num;
                    nechet = true;
                }
            }

            return nechet ? count : 0;
        }
    }
}