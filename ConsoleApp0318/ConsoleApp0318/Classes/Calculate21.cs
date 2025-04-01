using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    class Calculate21
    {
        public static void Process(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Console.WriteLine($"Индекс: {i}");
                    count++;
                }
            }

            Console.WriteLine($"Количество таких чисел: {count}");
        }
    }
}
