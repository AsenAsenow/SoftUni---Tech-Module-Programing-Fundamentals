﻿using System;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <=input; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(i+" ");
                }
            }

            
        }
    }
}
