using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AidemirAF.Sprint4.Task1.V20.Lib
{
    public class DataService : ISprint4Task1V20
    {
        public int Calculate(int[] array)
        {
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) 
                {
                    c += array[i];
                }
            }
            return c;
        }
    }
}
