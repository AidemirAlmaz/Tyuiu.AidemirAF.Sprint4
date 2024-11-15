using System.Data;
using System.Data.Common;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AidemirAF.Sprint4.Task7.V4.Lib
{
    public class DataService : ISprint4Task7V4
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value.Substring(i * m + j, 1)); // Convert не работает, потому что
                }
            }
            int c = 0;
            for (int i = 0;i < n; i++)
            {
                for (int j = 0;j < m; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        c += matrix[i, j];
                    }
                }
            }
            return c;
        }
    }
}
