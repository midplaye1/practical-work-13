using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    public class Calculate5
    {
        static bool IsBinaryFraction(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            string[] parts = input.Split('.');
            if (parts.Length < 2) return false;

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

        static double ConvertBinaryFractionToDecimal(string binaryFraction)
        {
            double decimalValue = 0;

            for (int i = 0; i < binaryFraction.Length; i++)
            {
                if (binaryFraction[i] == '1')
                {
                    decimalValue += Math.Pow(2, -(i + 1));
                }
            }
            return decimalValue;
        }
        static string ConvertDecimalToOctal(double decimalValue)
        {
            long integerPart = (long)decimalValue;
            double fractionalPart = decimalValue - integerPart;

            string octalIntegerPart = Convert.ToString(integerPart, 8);

            string octalFractionalPart = "";
            int count = 0;

            while (fractionalPart > 0 && count < 10)
            {
                fractionalPart *= 8;
                int octalDigit = (int)fractionalPart;
                octalFractionalPart += octalDigit.ToString();
                fractionalPart -= octalDigit;
                count++;
            }
            return octalIntegerPart + (octalFractionalPart.Length > 0 ? "." + octalFractionalPart : "");
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
            string fractionalPart = parts.Length > 1 ? parts[1] : "0";

            double decimalValue = ConvertBinaryToDecimal(integerPart);

            decimalValue += ConvertBinaryFractionToDecimal(fractionalPart);

            string octalValue = ConvertDecimalToOctal(decimalValue);

            Console.WriteLine($"Десятичное представление: {octalValue}");
        }
    }
}
