namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 11. Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. 
                  Se debe mostrar por pantalla el total de la suma de los números ingresados.  */

            int numero = 0;
            int acumul = 0;
            int j = 0;

            while (numero >= 0)
            {
                Console.WriteLine("Ingrese un número entero positivo");
                numero = Int32.Parse(Console.ReadLine());
                acumul = acumul + numero;
                Console.WriteLine($"{acumul}");
                j++;

            }
        }
    }
}
