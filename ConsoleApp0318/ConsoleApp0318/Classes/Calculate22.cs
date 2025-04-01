using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    class Calculate22
    {
        public static void Process(int[] array)
        {
            int lastIndex = -1;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i] < array[i + 1])
                {
                    lastIndex = i;
                }
            }

            if (lastIndex != -1)
            {
                Console.WriteLine($"Номер последнего элемента: {lastIndex}");
            }
            else
            {
                Console.WriteLine("Таких нет");
            }
        }
    }
}
