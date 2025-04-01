using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    class Calculate16
    {
        private string[] binaryArray;

        public Calculate16(string[] binaryArray)
        {
            this.binaryArray = binaryArray;
        }

        public void SwapMinMax()
        {
            int[] decimalArray = binaryArray.Select(b => Convert.ToInt32(b, 2)).ToArray();

            int minIndex = Array.IndexOf(decimalArray, decimalArray.Min());
            int maxIndex = Array.IndexOf(decimalArray, decimalArray.Max());

            string temp = binaryArray[minIndex];
            binaryArray[minIndex] = binaryArray[maxIndex];
            binaryArray[maxIndex] = temp;

            Console.WriteLine("Массив после замены минимального и максимального элементов:");
            Console.WriteLine(string.Join(", ", binaryArray));
        }
    }
}
