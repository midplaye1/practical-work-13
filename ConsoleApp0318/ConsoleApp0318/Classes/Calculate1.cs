using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    public class Calculate1
    {
        private string binaryString;
        public Calculate1(string binary)
        {
            if (!IsBinary(binary))
            {
                throw new FormatException("Некорректное двоичное число");
            }
            binaryString = binary;
        }
        public int ToDecimal()
        {
            int decimalNumber = 0;
            for (int i = 0; i < binaryString.Length; i++)
            {
                if (binaryString[binaryString.Length - 1 - i] == '1')
                {
                    decimalNumber += (1 << i);
                }
            }
            return decimalNumber;
        }
        private bool IsBinary(string binaryString)
        {
            foreach (char c in binaryString)
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
            Console.WriteLine("Введите двоичное число: ");
            binaryInput = Console.ReadLine();

            try
            {
                Calculate1 converter = new Calculate1(binaryInput);
                int decimalNumber = converter.ToDecimal();
                Console.WriteLine($"Десятичное представление: {decimalNumber}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

