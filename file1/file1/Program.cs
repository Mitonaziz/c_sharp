﻿using System;

namespace file1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine("number x is " +x);
            x = 5;
            Console.WriteLine("Number x is " + x);
            double double_num = 0.0d;
            float float_num = 0.0f;
            decimal decimal_num = 0.0m;

            double_num = 9.8;
            float_num = 5.5f;
            decimal_num = 100.250m;
            Console.WriteLine("Doble_num is "+double_num+" float_num is "+float_num+" decimal_num is "+decimal_num);
            string first_name = "Azizur";
            string last_name = "Rahman";
            Console.WriteLine("My first Name is " + first_name + " Last name is " +last_name);
            Console.ReadKey();
        }
    }
}
