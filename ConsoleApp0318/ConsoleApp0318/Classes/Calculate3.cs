using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    public class Calculate3
    {
        public bool IsBinary(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
        public void Calculate()
        {
            Console.Write("Введите двоичное число: ");
            string binaryInput = Console.ReadLine();

            if (!IsBinary(binaryInput))
            {
                Console.WriteLine("Ошибка: введено некорректное двоичное число.");
                return;
            }

            long decimalValue = Convert.ToInt64(binaryInput, 2);

            string hexValue = Convert.ToString(decimalValue, 16).ToUpper();

            Console.WriteLine($"Шестнадцатеричное представление: {hexValue}");
        }
    }
}
