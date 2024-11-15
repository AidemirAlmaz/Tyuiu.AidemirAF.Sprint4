using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AidemirAF.Sprint4.Task0.V13.Lib
{
    public class DataService : ISprint4Task0V13
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                c++;
            }
        return c;
        }
    }
}
