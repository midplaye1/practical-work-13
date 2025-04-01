using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318.Classes
{
    public class Calculate12
    {
        static int[] InputArray(int size)
        {
            int[] array = new int[size];
            Console.WriteLine($"Введите {size} элементов массива:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Ошибка: Введите целое число.");
                    Console.Write($"Элемент {i + 1}: ");
                }
            }
            return array;
        }

        static int[] FindDuplicatePositions(int[] array)
        {
            int[] positions = new int[2] { -1, -1 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        positions[0] = i;
                        positions[1] = j;
                        return positions;
                    }
                }
            }

            return positions;
        }
        public void Calculate()
        {
            Console.Write("Введите количество элементов массива: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = InputArray(size);
            int[] positions = FindDuplicatePositions(array);

            if (positions[0] != -1 && positions[1] != -1)
            {
                Console.WriteLine($"Два одинаковых элемента найдены на позициях: {positions[0] + 1} и {positions[1] + 1}");
            }
            else
            {
                Console.WriteLine("Два одинаковых элемента не найдены.");
            }
        }
    }
}
