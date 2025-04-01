using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    class Calculate25
    {
        public static void Process(int[] array)
        {
            int n = array.Length;
            int[] shiftedArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                shiftedArray[i] = array[(i + 1) % n];
            }

            int sumBefore = array.Sum();
            int sumAfter = shiftedArray.Sum();

            Console.WriteLine($"Сумма до сдвига: {sumBefore}");
            Console.WriteLine($"Сумма после сдвига: {sumAfter}");
        }
    }
}
