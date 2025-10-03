namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 12. Realizar algoritmo que permita obtener la suma de todos los números impares hasta el 99. */

            int number = 0;
            int acumulador = 0;
            int i = 1;

            while (number <= 99)
            {
                if (number % 2 != 0)
                {
                    acumulador += number;
                    Console.WriteLine($"{acumulador}");
                }
                number++;
            }
        }
    }
}
