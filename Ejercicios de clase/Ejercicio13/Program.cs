namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 13. Escribir un algoritmo que cuente cuántos números pares hay
                   en un rango de números del 1 al número n.  */

            int rango = 0;
            int cantidadPares = 0;
            int count = 1;

            Console.WriteLine("Ingrese la cantidad de números a evaluar");
            rango = Int32.Parse(Console.ReadLine());

            while (count <= rango)
            {
                if (count % 2 == 0)
                {
                    cantidadPares++;
                }
                count++;
            }
            Console.WriteLine($"La cantidad de pares entre 1 y {rango} es: {cantidadPares}");
        }
    }
}
