using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    class Calculate27
    {
        public static void Process(int[] array, double R)
        {
            int closestIndex = 0;
            double minDifference = Math.Abs(array[0] - R);

            for (int i = 1; i < array.Length; i++)
            {
                double difference = Math.Abs(array[i] - R);
                if (difference < minDifference)
                {
                    minDifference = difference;
                    closestIndex = i;
                }
            }

            Console.WriteLine($"Наиболее близкий элемент: {array[closestIndex]} на позиции {closestIndex}");
        }
    }
}
