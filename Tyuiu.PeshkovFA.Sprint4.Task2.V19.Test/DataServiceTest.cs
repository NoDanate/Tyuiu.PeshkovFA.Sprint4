using Tyuiu.PeshkovFA.Sprint4.Task2.V19.Lib;

namespace Tyuiu.PeshkovFA.Sprint4.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 7, 5};
            int wait = 54;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
