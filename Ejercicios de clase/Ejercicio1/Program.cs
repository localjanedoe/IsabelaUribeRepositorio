using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio1
{
    internal class Program
    {

        /* Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos 
         * mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos. */
        static void Main(string[] args)
        {
            string nombre = "";
            int saldo = 0;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su saldo");
            saldo = Convert.ToInt32(Console.ReadLine());
            if (saldo > 3000)
            {
                Console.WriteLine($"El usuario {nombre} debe abonar impuestos");
            }
            else
            {
                Console.WriteLine($"El usuario {nombre} está exento de impuestos");
            }
        }
    }
}
