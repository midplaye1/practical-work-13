using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    public class Calculate11
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

        static string[] RemoveDuplicates(string[] array)
        {
            Dictionary<string, int> countDict = new Dictionary<string, int>();

            foreach (string item in array)
            {
                if (countDict.ContainsKey(item))
                    countDict[item]++;
                else
                    countDict[item] = 1;
            }

            List<string> filteredList = new List<string>();
            foreach (string item in array)
            {
                if (countDict[item] <= 2)
                    filteredList.Add(item);
            }

            return filteredList.ToArray();
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
            int size = 12;
            string[] binaryArray = InputArray(size);
            string[] filteredArray = RemoveDuplicates(binaryArray);

            Console.WriteLine("Исходный массив:");
            PrintArray(binaryArray);

            Console.WriteLine("Массив после удаления элементов, встречающихся более двух раз:");
            PrintArray(filteredArray);
        }

    }
}
