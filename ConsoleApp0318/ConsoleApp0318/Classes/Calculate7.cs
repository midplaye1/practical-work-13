using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    public class Calculate7
    {
        public int[] InputArray(int size)
        {
            int[] array = new int[size];
            Console.WriteLine($"Введите {size} двузначных чисел:");

            for (int i = 0; i < size; i++)
            {
                while (true)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int number) && number >= 10 && number <= 99)
                    {
                        array[i] = number;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Введите двузначное число.");
                    }
                }
            }

            return array;
        }

        public int[] SwapDigitsInArray(int[] array)
        {
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = SwapDigits(array[i]);
            }

            return newArray;
        }

        private int SwapDigits(int number)
        {
            int tens = number / 10;
            int units = number % 10;
            return units * 10 + tens;
        }

        public void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        public void Calculate()
        {
            int size = 15;
            int[] originalArray = InputArray(size);
            int[] newArray = SwapDigitsInArray(originalArray);

            Console.WriteLine("Исходный массив:");
            PrintArray(originalArray);

            Console.WriteLine("Новый массив с измененными разрядами:");
            PrintArray(newArray);
        }
    }
}
