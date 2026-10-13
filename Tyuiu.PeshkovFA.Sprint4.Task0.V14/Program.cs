using Tyuiu.PeshkovFA.Sprint4.Task0.V14.Lib;

namespace Tyuiu.PeshkovFA.Sprint4.Task0.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            for (int i = 0; i < array.Length; i++) { 
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.GetSumOddArrEl(array);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
