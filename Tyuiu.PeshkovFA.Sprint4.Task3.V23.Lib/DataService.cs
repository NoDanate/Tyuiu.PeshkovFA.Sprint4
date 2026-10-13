using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PeshkovFA.Sprint4.Task3.V23.Lib
{
    public class DataService : ISprint4Task3V23
    {
        public int Calculate(int[,] array)
        {
            int cnt = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        cnt += 1;
                    }
                }
            }

            return cnt;
        }
    }
}
