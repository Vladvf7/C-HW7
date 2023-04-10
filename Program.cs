// Домашнее задание №7. Знакомство с языками программирования (семинары) Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// using System;

// namespace task47
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
            
//             Console.WriteLine("введите количество строк");
//  	        int linesVol = Convert.ToInt32(Console.ReadLine());
//  	        Console.WriteLine("введите количество столбцов");
//  	        int columnsVol = Convert.ToInt32(Console.ReadLine());
//  	        double[,] numbers = new double[linesVol, columnsVol];
//  	        FillArrayRandomNumbers(numbers);
//  	        PrintArray(numbers);
 	 
//  	        void FillArrayRandomNumbers(double[,] array)
//  	        {
//  	        for (int i = 0; i < array.GetLength(0); i++)
//                 {
//                     for (int j = 0; j < array.GetLength(1); j++)
//                     {
//                     array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//                     }
//                 }
//             }
 	 
//          	    void PrintArray(double[,] array)
//             {
//             for (int i = 0; i < array.GetLength(0); i++)
//             {
//             Console.Write("[ ");
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//             Console.Write(array[i, j] + " ");
//             }
//             Console.Write("]");
//             Console.WriteLine("");
//             }
//             }
//         }
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец), проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том, что оно найдено, а также какое число стоит на этом месте или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 3 -> Такой элемент есть: 3
// i = 4, j = 2 -> такого элемента в массиве нет

// using System;

// namespace task50
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
            
//         Console.WriteLine("введите номер строки");
//         int n = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("введите номер столбца");
//         int m = Convert.ToInt32(Console.ReadLine());
//         int [,] numbers = new int [10,10];
//         FillArrayRandomNumbers(numbers);
        
//         if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
//         {
//         Console.WriteLine("такого элемента нет");
//         }
//         else
//         {
//         Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
//         }
        
//         PrintArray(numbers);
        
//         void FillArrayRandomNumbers(int[,] array)
//         {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//         array [i,j] = new Random().Next(-100, 100)/10;
//         }
//         }
//         }
        
//         void PrintArray(int[,] array)
//         {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//         Console.Write(array[i,j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//         }
//         }

//         }
//     }
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;

namespace task52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество строк");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите количество столбцов");
            int m = Convert.ToInt32(Console.ReadLine());
            
            int[,] numbers = new int[n, m];
            FillArrayRandomNumbers(numbers);
            
            
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
            double avarage = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
            avarage = (avarage + numbers[i, j]);
            }
            avarage = avarage / n;
            Console.Write(avarage + "; ");
            }
            Console.WriteLine();
            PrintArray(numbers);
            
            
            
            void FillArrayRandomNumbers(int[,] array)
            {
            for (int i = 0; i < array.GetLength(0); i++)
            {
            for (int j = 0; j < array.GetLength(1); j++)
            {
            array[i, j] = new Random().Next(0, 10);
            }
            }
            }
            
            void PrintArray(int[,] array)
            {
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
            Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
            }
            }
        }
    }
}
