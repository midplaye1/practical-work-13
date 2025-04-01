using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    public class Calculate4
    {
        static bool IsBinaryFraction(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            string[] parts = input.Split('.');
            if (parts.Length > 2) return false;
            foreach (string part in parts)
            {
                foreach (char c in part)
                {
                    if (c != '0' && c != '1')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static double ConvertBinaryToDecimal(string binary)
        {
            double decimalValue = 0;
            int length = binary.Length;

            for (int i = 0; i < length; i++)
            {
                if (binary[length - 1 - i] == '1')
                {
                    decimalValue += Math.Pow(2, i);
                }
            }
            return decimalValue;
        }
        static double ConvertBinaryFractionToDecimal(string binaryfraction)
        {
            double decimalValue = 0;

            for (int i = 0; i < binaryfraction.Length; i++)
            {
                if (binaryfraction[i] == '1')
                {
                    decimalValue += Math.Pow(2, -(i + 1));
                }
            }
            return decimalValue;
        }

        public void Calculate()
        {
            Console.Write("Введите двоичное дробное число (например, 101.101): ");
            string binaryInput = Console.ReadLine();

            if (!IsBinaryFraction(binaryInput))
            {
                Console.WriteLine("ОШибка: введено некорректное двоичное дробное число.");
                return;
            }

            string[] parts = binaryInput.Split('.');
            string integerPart = parts[0];
            string fractionPart = parts.Length > 1 ? parts[1] : "0";

            double decimalValue = ConvertBinaryToDecimal(integerPart);

            decimalValue += ConvertBinaryFractionToDecimal(fractionPart);

            Console.WriteLine($"Десятичное представление: {decimalValue}");
        }
    }
}
