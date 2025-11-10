using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KononenkoVA.Sprint4.Task0.V19.Lib
{
    public class DataService : ISprint4Task0V19
    {
        public int GetMultOddArrEl(int[] array)
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