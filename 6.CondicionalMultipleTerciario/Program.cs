using System.Security.Cryptography;
using System.Text;

namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Condicional Múltiple

            float valorCompra = 0;
            float descuento = 0;
            char dia = ' ';
            Console.WriteLine("Ingrese el valor de la compra.");
            valorCompra = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el día de la semana: l:Lunes, m:Martes, x:Miércoles, j:Jueves, v:Viernes, s:Sábado, d:Domingo");
            dia = Convert.ToChar(Console.ReadLine());

            switch (dia)
            {
                case 'l':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es Lunes, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;

                case 'm':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es Martes, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;

                case 'x':
                    descuento = valorCompra * 0.1f;
                    Console.WriteLine($"Hoy es Miércoles, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;

                case 'j':
                    descuento = valorCompra * 0.15f;
                    Console.WriteLine($"Hoy es Jueves, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;

                case 'v':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es Viernes, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;

                case 's':
                    descuento = valorCompra * 0.2f;
                    Console.WriteLine($"Hoy es Sábado, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;

                case 'd':
                    descuento = valorCompra * 0;
                    Console.WriteLine($"Hoy es Domingo, descuento: {descuento}, valor a pagar: {valorCompra - descuento}");
                    break;

                default:
                    Console.WriteLine("Error. Ingrese un valor válido");
                    break;

                    //Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas
                    //entre dos números ingresados por el usuario.
                    //Las operaciones disponibles serán: suma, resta, multiplicación y división,
                    //las cuales se ejecutarán según la opción seleccionada por el usuario.

                    float num1 = 0;
                    float num2 = 0;
                    char operacion = ' ';

                    Console.WriteLine("Ingrese un primer número");
                    num1 = Single.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese un segundo número");
                    num2 = Single.Parse(Console.ReadLine());
                    Console.WriteLine("¿Qué operación desea hacer? (s:Suma, r:Resta, m:Multiplicación, d:División)");
                    operacion = Convert.ToChar(Console.ReadLine());

                    switch (operacion)
                    {
                        case 's':
                            Console.WriteLine($"La operación seleccionada es: Suma, por lo tanto: {num1} + {num2} = {num1 + num2}");
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

                        default:
                            Console.WriteLine("Error. Dato NO válido");
                            break;

                    }
            }
        }
    }
}
