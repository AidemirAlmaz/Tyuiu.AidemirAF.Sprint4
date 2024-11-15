using Tyuiu.AidemirAF.Sprint4.Task6.V1.Lib;

namespace Tyuiu.AidemirAF.Sprint4.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            var fruits = new string[] { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= fruits.Length - 1; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("Количество элементов в массиве, длина которых больше шести = " + ds.Calculate(fruits));

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
