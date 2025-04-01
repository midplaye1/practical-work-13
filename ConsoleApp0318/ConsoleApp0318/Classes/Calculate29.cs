using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    class Calculate29
    {
        public static void Process(string binaryPositive, string binaryNegative)
        {
            try
            {
                int positive = Convert.ToInt32(binaryPositive, 2);
                int negative = Convert.ToInt32(binaryNegative, 2);

                int sum = positive + negative;

                Console.WriteLine($"Сумма чисел: {Convert.ToString(sum, 2)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите двоичные числа, состоящие только из 0 и 1.");
            }
        }
    }
}
