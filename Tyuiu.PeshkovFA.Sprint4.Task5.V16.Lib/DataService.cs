using tyuiu.cources.programming.interfaces.Sprint4;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.PeshkovFA.Sprint4.Task5.V16.Lib
{
    public class DataService : ISprint4Task5V16
    {
        public int[,] Calculate(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 1)
                    {
                        array[i, j] = 1;
                    }
                }
            }

            return array;
        }
    }
}
