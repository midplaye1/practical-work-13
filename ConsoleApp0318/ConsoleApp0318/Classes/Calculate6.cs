using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    public class Calculate6
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
        static double ConvertBinatyToDecimal(string binary)
        {
            double decimalValue = 0;
            int length = binary.Length;

            for (int i = 0; 1 < length; i++)
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
        static string ConvertDecimalToHex(double decimalValue)
        {
            long integerPart = (long)decimalValue;
            double fractionalPart = decimalValue - integerPart;

            string hwxIntegerPart = Convert.ToString(integerPart, 16).ToUpper();

            string hexFractionalPart = "";
            int count = 0;

            while (fractionalPart > 0 && count < 10)
            {
                fractionalPart *= 16;
                int hexDigit = (int)fractionalPart;
                hexFractionalPart += hexDigit.ToString("Х");
                fractionalPart -= hexDigit;
                count++;
            }
            return hexFractionalPart + (hexFractionalPart.Length > 0 ? "." + hexFractionalPart : "");
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
            string inregerPart = parts[0];
            string fractionalPart = parts.Length > 1 ? parts[1] : "0";

            double decimalValue = ConvertBinaryFractionToDecimal(inregerPart);

            decimalValue += ConvertBinaryFractionToDecimal(fractionalPart);

            string hexValue = ConvertDecimalToHex(decimalValue);

            Console.WriteLine($"Шестнадцатеричное представление: {hexValue}");
        }
    }
}
