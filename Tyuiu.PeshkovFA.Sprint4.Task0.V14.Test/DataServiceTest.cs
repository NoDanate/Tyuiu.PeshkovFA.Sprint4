using Tyuiu.PeshkovFA.Sprint4.Task0.V14.Lib;

namespace Tyuiu.PeshkovFA.Sprint4.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            int wait = 30;

            int res = ds.GetSumOddArrEl(array);

            Assert.AreEqual(wait, res);
        }
    }
}
