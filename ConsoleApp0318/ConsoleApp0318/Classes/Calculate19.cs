using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    class Calculate19
    {
        public static void Process(int[] array)
        {
            int n = array.Length;
            if (n < 2)
            {
                Console.WriteLine("Не образуют");
                return;
            }

            int difference = array[1] - array[0];
            for (int i = 2; i < n; i++)
            {
                if (array[i] - array[i - 1] != difference)
                {
                    Console.WriteLine("Не образуют");
                    return;
                }
            }

            Console.WriteLine($"Разность прогрессии: {difference}");
        }
    }
}
