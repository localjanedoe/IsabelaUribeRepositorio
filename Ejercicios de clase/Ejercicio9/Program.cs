namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9. Escribir un algoritmo que permita generar primeros 5 números enteros positivos y realizar y mostrar su suma.

            int contador = 0;
            int acumulador = 0;

            while (contador <= 5)
            {
                acumulador += contador; //acumulador= acumulador + contador;
                Console.WriteLine($"C : {contador}, A: {acumulador}");
                contador++;
            }

            Console.WriteLine($"La suma de los primeros 5 enteros es {acumulador}");
        }
    }
}
