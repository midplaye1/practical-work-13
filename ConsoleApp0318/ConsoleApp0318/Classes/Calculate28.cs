using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    class Calculate28
    {
        public static void Process(int[] array, int D)
        {
            int farthestIndex = 0;
            double maxDifference = Math.Abs(array[0] - D);

            for (int i = 1; i < array.Length; i++)
            {
                double difference = Math.Abs(array[i] - D);
                if (difference > maxDifference)
                {
                    maxDifference = difference;
                    farthestIndex = i;
                }
            }

            Console.WriteLine($"Наиболее удаленный элемент: {array[farthestIndex]} на позиции {farthestIndex}");
        }
    }
}
