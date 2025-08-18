using System.Collections.Specialized;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float des = 0.17f;
            float cuento = 0.02f;
            string nombre = "";
            int precio = 200;
            int noches = 0;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("¿Cuántas noches se va a hospedar? (Dato en números)");
            noches = Convert.ToInt32(Console.ReadLine());

            if (noches >= 3)
            {
                Console.WriteLine($"{nombre}, El total a pagar es: {(precio*noches)*des} dólares");
            }
            else
            {
                Console.WriteLine($"{nombre}, El total a pagar es: {(precio * noches) * cuento} dólares");
            }
        }
    }
}
