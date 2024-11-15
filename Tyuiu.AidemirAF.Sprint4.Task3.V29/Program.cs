using Tyuiu.AidemirAF.Sprint4.Task3.V29.Lib;

namespace Tyuiu.AidemirAF.Sprint4.Task3.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5] {
            { 9, 9, 8, 6, 9},
            { 5, 8, 8, 8, 7},
            { 6, 5, 9, 7, 9},
            { 7, 7, 9, 7, 8},
            { 8, 5, 8, 5, 5} };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("Произведение элементов первого столбца массива = " + ds.Calculate(array));
            Console.ReadKey();

        }
    }
}