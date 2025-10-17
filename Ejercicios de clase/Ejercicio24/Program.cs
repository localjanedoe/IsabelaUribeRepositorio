namespace Ejercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 24. Algoritmo que permita solicitar 10 números, los cuales serán almacenados en un arreglo, al final, debe visualizar 
                     el promedio de esos números. */

            int[] numeros = new int[10];
            float suma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingrese el número {i}");
                numeros[i] = Int32.Parse(Console.ReadLine());
                suma += numeros[i];
            }

            Console.WriteLine($"El promedio del arreglo es de: {(suma)/10}");


        }
    }
}
