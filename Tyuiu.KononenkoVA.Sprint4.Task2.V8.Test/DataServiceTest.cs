using Tyuiu.KononenkoVA.Sprint4.Task2.V8.Lib;

namespace Tyuiu.KononenkoVA.Sprint4.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 6 };

            int result = ds.Calculate(array);
            int wait = 23;

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateNoOdd()
        {
            DataService ds = new DataService();

            int[] array = { 2, 4, 6, 2, 4, 6, 2, 4, 6, 2, 4 };

            int result = ds.Calculate(array);
            int wait = 0;

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateAllOdd()
        {
            DataService ds = new DataService();

            int[] array = { 3, 5, 7, 3, 5, 7, 3, 5, 7, 3, 5 };

            int result = ds.Calculate(array);
            int wait = 53;

            Assert.AreEqual(wait, result);
        }
    }
}