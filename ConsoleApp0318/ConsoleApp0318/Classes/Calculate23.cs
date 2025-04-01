using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    class Calculate23
    {
        public static void Process(int[] array)
        {
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            int start = Math.Min(minIndex, maxIndex);
            int end = Math.Max(minIndex, maxIndex);
            int count = end - start - 1;

            if (count > 0)
            {
                Console.WriteLine($"Количество чисел между минимальным и максимальным: {count}");
            }
            else
            {
                Console.WriteLine("Таких чисел нет");
            }
        }
    }
}
