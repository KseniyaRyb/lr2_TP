﻿using System;

namespace lr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            double Num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите операцию: ");
            string zh = Console.ReadLine();
            Console.WriteLine("Введите число: ");
            double Num2 = Convert.ToDouble(Console.ReadLine());
            double res = double.NaN;

            if (zh == "+")
                res = Num1 + Num2;
            else if (zh == "-")
                res = Num1 - Num2;
            else if (zh == "/")
                if (Num2 == 0)
                {
                    Console.WriteLine("Нельзя делить на 0");
                }
                else
                {
                    res = Num1 / Num2;
                }

            else if (zh == "*")
                res = Num1 * Num2;
            Console.WriteLine(res);
        }
    }
}
