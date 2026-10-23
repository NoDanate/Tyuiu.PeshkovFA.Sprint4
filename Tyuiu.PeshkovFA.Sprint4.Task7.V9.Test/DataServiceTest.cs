using Tyuiu.PeshkovFA.Sprint4.Task7.V9.Lib;

namespace Tyuiu.PeshkovFA.Sprint4.Task7.V9.Test
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
            
            int wait = 4;

            int res = ds.Calculate(n, m, value);

            Assert.AreEqual(wait, res);
        }
    }
}
