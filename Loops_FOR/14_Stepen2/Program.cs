﻿namespace _14_Stepen2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"{i}^2={i*i}");
            }

        }
    }
}
