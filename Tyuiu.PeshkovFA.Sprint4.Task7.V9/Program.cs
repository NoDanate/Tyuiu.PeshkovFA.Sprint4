using Tyuiu.PeshkovFA.Sprint4.Task7.V9.Lib;

namespace Tyuiu.PeshkovFA.Sprint4.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int n = 3;
            int m = 3;
            string value = "864299753";

            Console.WriteLine("Длина: " + n + "\nШирина: " + m + "\nСтрока: " + value);

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, value);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
