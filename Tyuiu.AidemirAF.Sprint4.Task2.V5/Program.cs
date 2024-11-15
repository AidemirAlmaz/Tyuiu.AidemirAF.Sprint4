using Tyuiu.AidemirAF.Sprint4.Task2.V5.Lib;

namespace Tyuiu.AidemirAF.Sprint4.Task2.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataServcie ds = new DataServcie();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");

            int len;
            Console.WriteLine("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(3, 9);
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(numsArray[i] + "\t");
            }
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                        *");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("Произведение четных элементов массива = " + ds.Calculate(numsArray));
            Console.ReadKey();
        }
    }
}
