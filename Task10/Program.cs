﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}
