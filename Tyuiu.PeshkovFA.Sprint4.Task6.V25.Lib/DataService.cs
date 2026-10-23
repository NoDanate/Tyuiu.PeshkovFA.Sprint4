using System.Security;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PeshkovFA.Sprint4.Task6.V25.Lib
{
    public class DataService : ISprint4Task6V25
    {
        public int Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, str => str.Length > 6);
            return res.Length;
        }
    }
}
