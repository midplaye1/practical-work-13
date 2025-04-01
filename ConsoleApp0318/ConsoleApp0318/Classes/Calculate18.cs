using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    class Calculate18
    {
        public static void Process(int[] array)
        {
            int increasingSum = 0;
            int decreasingSum = 0;
            int n = array.Length;
            if (n == 0) return;

            int currentSum = array[0];
            bool isIncreasing = true;

            for (int i = 1; i < n; i++)
            {
                if (array[i] > array[i - 1])
                {
                    if (!isIncreasing)
                    {
                        decreasingSum += currentSum;
                        currentSum = 0;
                    }
                    isIncreasing = true;
                }
                else if (array[i] < array[i - 1])
                {
                    if (isIncreasing)
                    {
                        increasingSum += currentSum;
                        currentSum = 0;
                    }
                    isIncreasing = false;
                }

                currentSum += array[i];
            }

            if (isIncreasing)
            {
                increasingSum += currentSum;
            }
            else
            {
                decreasingSum += currentSum;
            }

            Console.WriteLine($"Разность между суммой возрастающих и убывающих участков: {increasingSum - decreasingSum}");
        }
    }
}
