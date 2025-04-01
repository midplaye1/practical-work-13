using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    public class Calculate10
    {
        static double[] InputArray(int size, string arrayName)
        {
            double[] array = new double[size];
            Console.WriteLine($"Введите {size} элементов {arrayName} массива:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Ошибка: Введите действительное число.");
                    Console.Write($"Элемент {i + 1}: ");
                }
            }
            return array;
        }

        static double[] MergeAndSortArrays(double[] array1, double[] array2)
        {
            double[] mergedArray = array1.Concat(array2).ToArray();
            Array.Sort(mergedArray);
            Array.Reverse(mergedArray);
            return mergedArray;
        }

        static void PrintArray(double[] array)
        {
            foreach (double num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        public void Calculate()
        {
            int size1 = 7;
            int size2 = 9;

            double[] array1 = InputArray(size1, "первого");
            double[] array2 = InputArray(size2, "второго");

            double[] mergedArray = MergeAndSortArrays(array1, array2);

            Console.WriteLine("Первый массив:");
            PrintArray(array1);

            Console.WriteLine("Второй массив:");
            PrintArray(array2);

            Console.WriteLine("Третий массив (объединенный и отсортированный по убыванию):");
            PrintArray(mergedArray);
        }
    }
}
