using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    class Calculate30
    {
        public static void Process(int[] array)
        {
            string[] binaryArray = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                binaryArray[i] = Convert.ToString(array[i], 2);
            }

            Console.WriteLine("Массив в двоичной системе:");
            Console.WriteLine(string.Join(", ", binaryArray));
        }
    }
}
