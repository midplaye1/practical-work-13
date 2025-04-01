using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    class Calculate26
    {
        public static void Process(int[] array)
        {
            int binaryNumber = Convert.ToInt32("1010", 2);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += binaryNumber;
            }

            Console.WriteLine("Массив после увеличения на 1010:");
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
