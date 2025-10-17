namespace Ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  17. Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10.
                     Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar */

            int count = 1;
            int acum = 0;
            int dato = 0;
            string respuesta = "";

            do
            {
                Console.WriteLine("Ingrese un número");
                dato = Int32.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine($"{dato} * {count} = {dato * count}");
                    count++;
                } while (count < 11);

                Console.WriteLine("¿Desea generar una nueva tabla de multiplicar? s: sí , n:no");
                respuesta = Console.ReadLine().ToLower();
                count = 1;

            } while (respuesta == "s");
        }
    }
}
