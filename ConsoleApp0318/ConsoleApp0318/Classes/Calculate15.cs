using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    public class Calculate15
    {
        static string[] InputArray(int size)
        {
            string[] array = new string[size];
            Console.WriteLine($"Введите {size} двоичных чисел:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                string input = Console.ReadLine();
                while (!IsBinary(input))
                {
                    Console.WriteLine("Ошибка: Введите двоичное число (состоящее только из 0 и 1).");
                    Console.Write($"Элемент {i + 1}: ");
                    input = Console.ReadLine();
                }
                array[i] = input;
            }
            return array;
        }

        static bool IsBinary(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                    return false;
            }
            return true;
        }

        static string[] SortArrayAscending(string[] array)
        {
            return array.OrderBy(x => Convert.ToInt32(x, 2)).ToArray();
        }

        static double CalculateAverage(string[] array)
        {
            int sum = array.Sum(x => Convert.ToInt32(x, 2));
            return (double)sum / array.Length;
        }

        static void PrintArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public void Calculate()
        {
            Console.Write("Введите количество элементов массива: ");
            int size = int.Parse(Console.ReadLine());

            string[] binaryArray = InputArray(size);
            string[] sortedArray = SortArrayAscending(binaryArray);
            double average = CalculateAverage(sortedArray);

            Console.WriteLine("Отсортированный массив по возрастанию:");
            PrintArray(sortedArray);

            Console.WriteLine($"Среднее значение чисел в десятичной системе: {average}");
        }
    }
}
