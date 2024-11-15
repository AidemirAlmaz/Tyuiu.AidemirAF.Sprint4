using Tyuiu.AidemirAF.Sprint4.Task7.V4.Lib;

namespace Tyuiu.AidemirAF.Sprint4.Task7.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int rows = 3;
            int columns = 4;
            int[,] matrix = new int[rows, columns];
            string str = "382976421897";

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("Сумма нечетных чисел = " + ds.Calculate(rows, columns, str));
            Console.ReadKey();
        }
    }
}
