﻿namespace _21.For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;

            for     (int i = 1; i <= 5; i++)
            {
                acumulador += i;
            }

            Console.WriteLine($"La suma de los primeros 5 números enteros es: {acumulador}");

        
        }
    }
}
