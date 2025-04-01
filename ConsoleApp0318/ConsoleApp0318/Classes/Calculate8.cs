using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    public class Calculate8
    {
        static int[] InputArray(int size)
        {
            int[] array = new int[size];
            Console.WriteLine($"Введите {size} двузначных чисел в восьмеричной системе счисления:");
            for (int i = 0; i < size; i++)
            {
                while (true)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    string input = Console.ReadLine();
                    if (IsValidOctal(input))
                    {
                        array[i] = Convert.ToInt32(input, 8);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Введите двузначное число в восьмеричной системе счисления (от 00 до 77).");
                    }
                }
            }
            return array;
        }

        static bool IsValidOctal(string input)
        {
            if (input.Length != 2)
                return false;

            foreach (char c in input)
            {
                if (c < '0' || c > '7')
                    return false;
            }
            return true;
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        public void Calculate()
        {
            int size = 9;
            int[] originalArray = InputArray(size);

            Console.WriteLine("Массив в десятичной системе счисления:");
            PrintArray(originalArray);
        }
    }
}
