using Tyuiu.PeshkovFA.Sprint4.Task5.V16.Lib;

namespace Tyuiu.PeshkovFA.Sprint4.Task5.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[,] { { -6, 3, 0, 1, -2 },
                                        { 3, -5, -6, 3, 2 },
                                        { 2, 1, 0, -6, -5 },
                                        { 0, 1, -5, 3, -1 },
                                        { -3, 2, 2, -4, 3 }};
            int[,] wait = { { -6, 1, 0, 1, -2 },
                            { 1, -5, -6, 1, 1 },
                            { 1, 1, 0, -6, -5 },
                            { 0, 1, -5, 1, -1 },
                            { -3, 1, 1, -4, 1 }};

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
