using Tyuiu.KononenkoVA.Sprint4.Task7.V9.Lib;

namespace Tyuiu.KononenkoVA.Sprint4.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 3;
            string value = "864299753";

            int result = ds.Calculate(n, m, value);
            int wait = 4; // Четные числа: 8, 6, 4, 2

            Assert.AreEqual(wait, result);
        }
    }
}