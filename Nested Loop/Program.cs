﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("hello ammar");
                for (int j = 0; j < 2; j++) 
                {
                    Console.WriteLine("hello world");

                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();


        }
    }
}
