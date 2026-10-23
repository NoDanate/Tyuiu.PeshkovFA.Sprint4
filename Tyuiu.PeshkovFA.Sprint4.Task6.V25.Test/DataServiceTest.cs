using Tyuiu.PeshkovFA.Sprint4.Task6.V25.Lib;

namespace Tyuiu.PeshkovFA.Sprint4.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = new string[] { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };
            int wait = 2;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
