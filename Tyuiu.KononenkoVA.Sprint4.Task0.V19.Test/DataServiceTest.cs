using Tyuiu.KononenkoVA.Sprint4.Task0.V19.Lib;

namespace Tyuiu.KononenkoVA.Sprint4.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int result = ds.GetMultOddArrEl(array);
            int wait = 9 * 5 * 7 * 5 * 3 * 7 * 9 * 1;
            Assert.AreEqual(wait, result);
        }
    }
}