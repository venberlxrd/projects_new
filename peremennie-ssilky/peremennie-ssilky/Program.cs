﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peremennie_ssilky
{
    class Program
    {
        static ref int Max(ref int n1, ref int n2)
        {
            if (n1 > n2)
            return ref n1;

            else
            return ref n2;
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 8;

            ref int pointer = ref Max(ref a, ref b);

            pointer = 34;   
            Console.WriteLine($"a: {a}  b: {b}");

            Console.ReadKey();
        }
    }
}
