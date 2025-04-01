using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    public class Calculate9
    {
        static int[] InputArray(int size)
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

        static int[] ExtractHighDigits(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i] / 10;
            }
            return newArray;
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
            int size = 7;
            int[] originalArray = InputArray(size);
            int[] newArray = ExtractHighDigits(originalArray);

            Console.WriteLine("Исходный массив:");
            PrintArray(originalArray);

            Console.WriteLine("Новый массив из старших разрядов:");
            PrintArray(newArray);
        }
    }
}
