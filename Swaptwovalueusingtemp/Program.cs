﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaptwovalueusingtemp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a = " + a); 
            Console.WriteLine("b = " + b); 
            Console.ReadKey();

        }
    }
}
