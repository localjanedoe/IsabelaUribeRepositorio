using System.Security.Cryptography;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas
            //entre dos números ingresados por el usuario.
            //Las operaciones disponibles serán: suma, resta, multiplicación y división,
            //las cuales se ejecutarán según la opción seleccionada por el usuario.

            float num1 = 0;
            float num2 = 0;
            char operacion= ' ';

            Console.WriteLine("Ingrese un primer número");
            num1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número");
            num2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("¿Qué operación desea hacer? (s:Suma, r:Resta, m:Multiplicación, d:División)");
            operacion = Convert.ToChar(Console.ReadLine());

            switch (operacion)
            {
                case 's': 
                    Console.WriteLine($"La operación seleccionada es: Suma, por lo tanto: {num1} + {num2} = {num1+num2}");
                    break;

                case 'r':
                    Console.WriteLine($"La operación seleccionada es: Resta, por lo tanto: {num1} - {num2} = {num1 - num2}");
                    break;

                case 'm':
                    Console.WriteLine($"La operación seleccionada es: Multiplicación, por lo tanto: {num1} * {num2} = {num1 * num2}");
                    break;

                case 'd':
                    Console.WriteLine($"La operación seleccionada es: División, por lo tanto: {num1} / {num2} = {num1 / num2}");
                    break;

                default: Console.WriteLine("Error. Dato NO válido");
                    break;
            }
        }
    }
}
