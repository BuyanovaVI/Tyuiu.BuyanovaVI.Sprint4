﻿
using Tyuiu.BuyanovaVI.Sprint4.Task0.V30.Lib;

namespace Tyuiu.BuyanovaVI.Sprint4.Task0.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнилa: Буянова В. И. | СМАРТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнилa: Буянова В. И. | СМАРТб-24-1                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных   *");
            Console.WriteLine("* элементов массива.  {9, 8, 4, 6, 9, 4, 3, 6, 1, 2}                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");

            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

            Console.Write(" Массив = {");
            for (int element = 0; element < array.Length; element++)
            {
                if (element == 0)
                {
                    Console.Write($" {array[element]}");
                }
                else
                {
                    Console.Write($", {array[element]}");
                }
            }
            Console.WriteLine(" }");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма четных элементов = " + ds.GetSumEvenArrEl(array));
            Console.ReadKey();
        }
    }
}
