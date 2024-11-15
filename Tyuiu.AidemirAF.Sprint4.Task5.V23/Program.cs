using Tyuiu.AidemirAF.Sprint4.Task5.V23.Lib;

namespace Tyuiu.AidemirAF.Sprint4.Task5.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            Console.WriteLine("Введите количество строк в массиве:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве:");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            Console.WriteLine("*****************************************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(-4, 8);
                }
            }
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0;j < columns; j++)
                {
                    Console.WriteLine($"{matrix[i, j]} \t");
                }
            }
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");
            matrix = ds.Calculate(matrix);
            Console.WriteLine("\nРезультирующий массив: ");
            for (int i = 0;i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] +"\t");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
