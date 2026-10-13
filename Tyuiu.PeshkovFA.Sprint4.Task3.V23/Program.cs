using Tyuiu.PeshkovFA.Sprint4.Task3.V23.Lib;

namespace Tyuiu.PeshkovFA.Sprint4.Task3.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                       { 7, 5, 5, 6, 7 }                                 *");
            Console.WriteLine("*                       { 8, 7, 8, 4, 3 }                                 *");
            Console.WriteLine("*                       { 5, 6, 7, 8, 3 }                                 *");
            Console.WriteLine("*                       { 4, 2, 3, 6, 4 }                                 *");
            Console.WriteLine("*                       { 5, 2, 4, 2, 3 }                                 *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[,] { { 7, 5, 5, 6, 7 },
                                        { 8, 7, 8, 4, 3 },
                                        { 5, 6, 7, 8, 3 },
                                        { 4, 2, 3, 6, 4 },
                                        { 5, 2, 4, 2, 3 }};



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
