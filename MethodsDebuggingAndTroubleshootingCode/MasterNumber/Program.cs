﻿using System;

namespace MasterNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (IsPalindrome(i.ToString()) && SumDivisible(i)) { Console.WriteLine(i); }
            }
        }

        static bool IsPalindrome(string n)
        {
            for (int i = 0; i < n.Length / 2; i++)
            {
                if (n[i] != n[n.Length - 1 - i]) { return false; }
            }
            return true;
        }
        static bool SumDivisible(int n)
        {
            bool evenDigit = false; bool divisible = false;
            int sum = 0;
            while (n != 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0) { evenDigit = true; }
                sum += lastDigit;
                n /= 10;
            }
            if (sum % 7 == 0) { divisible = true; }
            if (evenDigit && divisible) { return true; }
            else { return false; }
        }
    }
}
