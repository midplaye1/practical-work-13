using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    public class Calculate13
    {

        static bool IsBinary(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                    return false;
            }
            return true;
        }

        static string CyclicShiftLeft(string binaryNumber, int positions)
        {
            positions = positions % binaryNumber.Length;
            string shiftedPart = binaryNumber.Substring(0, positions);
            string remainingPart = binaryNumber.Substring(positions);
            return remainingPart + shiftedPart;
        }
        public void Calculate()
        {
            Console.Write("Введите двоичное число: ");
            string binaryNumber = Console.ReadLine();

            if (!IsBinary(binaryNumber))
            {
                Console.WriteLine("Ошибка: Введенная строка не является двоичным числом.");
                return;
            }

            string shiftedNumber = CyclicShiftLeft(binaryNumber, 2);
            int originalNumber = Convert.ToInt32(binaryNumber, 2);
            int shiftedNumberValue = Convert.ToInt32(shiftedNumber, 2);
            int difference = originalNumber - shiftedNumberValue;

            Console.WriteLine($"Исходное число: {binaryNumber} (в десятичной системе: {originalNumber})");
            Console.WriteLine($"Число после сдвига: {shiftedNumber} (в десятичной системе: {shiftedNumberValue})");
            Console.WriteLine($"Разность исходного и полученного числа: {difference}");
        }
    }
}
