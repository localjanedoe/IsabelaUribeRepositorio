namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10. Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1 * 2 * 3 * 4 * 5)
            int acum = 1;
            int contador = 1;
            int num = 0;

            Console.WriteLine("Ingrese el número el cuál desea saber su factorial");
            num = Int32.Parse(Console.ReadLine());

            while (contador <= num)
            {
                acum *= contador;
                contador++;
            }

            Console.WriteLine($"El factorial de {num} es {acum}");

        }
    }
}
