using System.Security.Cryptography;
using Tyuiu.AidemirAF.Sprint4.Task0.V13.Lib;

/*
 * ЗАДАНИЕ
 * Дан одномерный целочисленный массив на 10 элементов заполненный статистическими значениями в диапозоне от 0 до 9
 * подсчитать сумму четных элементов массива. {2, 6, 2, 3, 4, 5, 4, 9, 7, 8}
 */

namespace Tyuiu.AidemirAF.Sprint4.Task0.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            int[] numsArray = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("Сумма четных элементов массива = " + ds.GetSumEvenArrEl(numsArray));
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
