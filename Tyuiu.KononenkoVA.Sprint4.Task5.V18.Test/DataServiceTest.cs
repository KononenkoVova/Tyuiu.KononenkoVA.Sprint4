using Tyuiu.KononenkoVA.Sprint4.Task5.V18.Lib;

namespace Tyuiu.KononenkoVA.Sprint4.Task5.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                { -1, 2, -3, 4, -5 },
                { 6, -2, 1, -4, 3 },
                { -6, 7, 0, -1, 2 },
                { 3, -3, 5, -2, 1 },
                { -4, 4, -6, 5, -1 }
            };

            int[,] result = ds.Calculate(matrix);

            int[,] wait = new int[5, 5]
            {
                { 0, 2, 0, 4, 0 },
                { 6, 0, 1, 0, 3 },
                { 0, 7, 0, 0, 2 },
                { 3, 0, 5, 0, 1 },
                { 0, 4, 0, 5, 0 }
            };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}