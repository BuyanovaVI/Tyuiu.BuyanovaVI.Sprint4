﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BuyanovaVI.Sprint4.Task6.V13.Lib
{
    public class DataService : ISprint4Task6V13
    {
        public int Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, carmark => carmark.Length > 4);
            return mas.Length;
        }
    }
}