using Tyuiu.KononenkoVA.Sprint4.Task4.V3.Lib;

namespace Tyuiu.KononenkoVA.Sprint4.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                {7, 9, 7, 8, 6},
                {4, 4, 4, 8, 6},
                {7, 9, 6, 7, 6},
                {7, 5, 4, 9, 8},
                {9, 6, 4, 9, 8}
            };

            int result = ds.Calculate(array);
            int wait = 91;

            Assert.AreEqual(wait, result);
        }
    }
}