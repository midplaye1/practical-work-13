using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    class Calculate20
    {
        public static void Process(int[] array)
        {
            int n = array.Length;
            if (n < 2)
            {
                Console.WriteLine("Не образуют");
                return;
            }

            double ratio = (double)array[1] / array[0];
            for (int i = 2; i < n; i++)
            {
                if ((double)array[i] / array[i - 1] != ratio)
                {
                    Console.WriteLine("Не образуют");
                    return;
                }
            }

            Console.WriteLine($"Знаменатель прогрессии: {ratio}");
        }
    }
}
