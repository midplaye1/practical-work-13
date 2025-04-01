using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp0318.Classes;

namespace ConsoleApp0318
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа № 13");
            Console.WriteLine("1 - 30");
            int input = Convert.ToInt32(Console.ReadLine());

            int n;


            switch (input)
            {
                case 1:

                    Calculate1 calculator1 = new Calculate1(Console.ReadLine());
                    calculator1.Calculate();
                    break;

                case 2:

                    Calculate2 calculation2 = new Calculate2();
                    calculation2.Calculate();
                    break;

                case 3:

                    Calculate3 calculator3 = new Calculate3();
                    calculator3.Calculate();
                    break;

                case 4:

                    Calculate4 calculator4 = new Calculate4();
                    calculator4.Calculate();
                    break;

                case 5:
                    Calculate5 calculator5 = new Calculate5();
                    calculator5.Calculate();
                    break;

                case 6:
                    Calculate6 calculator6 = new Calculate6();
                    calculator6.Calculate();
                    break;

                case 7:
                    Calculate7 calculator7 = new Calculate7();
                    calculator7.Calculate();
                    break;

                case 8:
                    Calculate8 calculator8 = new Calculate8();
                    calculator8.Calculate();
                    break;

                case 9:
                    Calculate9 calculator9 = new Calculate9();
                    calculator9.Calculate();
                    break;

                case 10:
                    Calculate10 calculator10 = new Calculate10();
                    calculator10.Calculate();
                    break;

                case 11:
                    Calculate11 calculator11 = new Calculate11();
                    calculator11.Calculate();
                    break;

                case 12:
                    Calculate12 calculator12 = new Calculate12();
                    calculator12.Calculate();
                    break;

                case 13:
                    Calculate13 calculator13 = new Calculate13();
                    calculator13.Calculate();
                    break;

                case 14:
                    Calculate14 calculator14 = new Calculate14();
                    calculator14.Calculate();
                    break;

                case 15:
                    Calculate15 calculator15 = new Calculate15();
                    calculator15.Calculate();
                    break;

                case 16:
                    Console.WriteLine("Введите количество элементов в массиве:");
                    n = int.Parse(Console.ReadLine());

                    string[] binaryArray16 = new string[n];

                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Введите элемент {i + 1} в двоичной системе:");
                        binaryArray16[i] = Console.ReadLine();
                    }

                    Calculate16 swapper = new Calculate16(binaryArray16);
                    swapper.SwapMinMax();
                    break;

                case 17:
                    Console.WriteLine("Введите количество элементов в массиве:");
                    n = int.Parse(Console.ReadLine());

                    int[] array17 = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"Введите элемент {i + 1}:");
                        array17[i] = int.Parse(Console.ReadLine());
                    }
                    
                    Calculate17.Process(array17);
                    break;

                case 18:
                    int[] array18 = { 10, 29, 32, 2, 1, 41, 5, 12, 3, 24 };

                    Calculate18.Process(array18);
                    break;

                case 19:
                    int[] array19 = { 12, 21, 34, 22, 15, 46, 53, 62, 3, 2 };

                    Calculate19.Process(array19);
                    break;

                case 20:
                    int[] array20 = { 11, 22, 3, 2, 15, 4, 52, 6, 31, 24 };

                    Calculate20.Process(array20);
                    break;

                case 21:
                    int[] array21 = { 1, 2, 3, 2, 1, 4, 5, 6, 3, 2 };

                    Calculate21.Process(array21);
                    break;

                case 22:
                    int[] array22 = { 1, 2, 3, 2, 1, 4, 5, 6, 3, 2 };

                    Calculate22.Process(array22);
                    break;

                case 23:
                    {
                        int[] array = { 101, 100, 10, 01, 001, 010 };
                       
                        Calculate23.Process(array);
                    }
                    break;

                case 24:
                    int[] array24 = { 101, 100, 1111, 01, 001, 111 };

                    Calculate24.Process(array24);
                    break;

                case 25:
                    int[] array25 = { 101, 001, 1001, 10, 010 };

                    Calculate25.Process(array25);
                    break;

                case 26:
                    int[] array26 = { 101, 001, 1001, 10, 010 };

                    Calculate26.Process(array26);
                    break;

                case 27:
                    int[] array27 = { 1, 5, 10, 15, 20 };
                    Console.WriteLine("Введите число R:");
                    double R = double.Parse(Console.ReadLine());
                    
                    Calculate27.Process(array27, R);
                    break;

                case 28:
                    int[] array28 = { 1, 5, 10, 15, 20 }; 
                    Console.WriteLine("Введите число D:");
                    int D = int.Parse(Console.ReadLine());

                    Calculate28.Process(array28, D);
                    break;

                case 29:
                    Console.WriteLine("Введите положительное двоичное число:");
                    string binaryPositive = Console.ReadLine();

                    Console.WriteLine("Введите отрицательное двоичное число:");
                    string binaryNegative = Console.ReadLine();

                    Calculate29.Process(binaryPositive, binaryNegative);
                    break;

                case 30:
                    int[] array30 = { 2, 9, 11 };

                    Calculate30.Process(array30);
                    break;
            }
        }
    }
}
