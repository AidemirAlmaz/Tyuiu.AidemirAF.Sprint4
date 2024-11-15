using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AidemirAF.Sprint4.Task3.V29.Lib
{
    public class DataService : ISprint4Task3V29
    {
        public int Calculate(int[,] array)
        {
            int c = 1;
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; i < columns; i++)
                {
                    if (array[i, j] == array[i, 0]) 
                    {
                        c*= array[i, 0];
                    }
                }
            }
            return c;
        }
    }
}
