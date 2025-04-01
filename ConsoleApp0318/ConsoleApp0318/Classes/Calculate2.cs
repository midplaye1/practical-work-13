using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    public class Calculate2
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
            string binaryInput;
            long decimalValue;
            string octalValue;
            Console.WriteLine("Введите двоичное число: ");
            binaryInput = Console.ReadLine();

            if (!IsBinary(binaryInput))
            {
                Console.WriteLine("Ошибка: введено некорректное двоичное число.");
                return;
            }

            decimalValue = Convert.ToInt64(binaryInput, 2);

            octalValue = Convert.ToString(decimalValue, 8);

            Console.WriteLine($"Восьмеричное представление: {octalValue}");
        }

    }
}
