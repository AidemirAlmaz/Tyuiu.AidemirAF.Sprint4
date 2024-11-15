﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AidemirAF.Sprint4.Task2.V5.Lib
{
    public class DataServcie : ISprint4Task2V5
    {
        public int Calculate(int[] array)
        {
            int c = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) 
                {
                    c *= array[i];
                }
            }
            return c;
        }
    }
}
