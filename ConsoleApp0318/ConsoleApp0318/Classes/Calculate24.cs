using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    class Calculate24
    {
        public static void Process(int[] array)
        {
            int n = array.Length;
            int[] shiftedArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                shiftedArray[(i + 1) % n] = array[i];
            }

            Console.WriteLine("Массив после сдвига вправо:");
            Console.WriteLine(string.Join(", ", shiftedArray));
        }
    }
}
