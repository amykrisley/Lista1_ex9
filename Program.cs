﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r;
            double d;
            double a;

            Console.Write("informe o valor do diâmetro: ");
            d = double.Parse(Console.ReadLine());

            r = d / 2;

            a = Math.PI * Math.Pow(r, 2);

            Console.WriteLine("o valor da área é: {0}", a);
        }
    }
}
