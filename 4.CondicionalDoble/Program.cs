using System.Net;

namespace _4.CondicionalDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crear un algoritmo que permita  ingresar el nombre y el sueldo  de una persona,
               si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona,
               indicando que debe abonar impuestos, de lo contario mostrar el mensaje "Persona exenta de impuestos*/

            string name = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            name = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo");
            sueldo = Convert.ToInt32(Console.ReadLine());

            if (sueldo >= 3000)
            {
                Console.WriteLine($"La persona {name} debe abonar impuestos ");
            }
            else
            {
                Console.WriteLine($"La persona {name} está exenta de impuestos");
            }

            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de edad
              se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web". De lo contrario
              mostrar el mensaje: "No es apto para el contenido de este sitio web" */

            int edad = 0;

            Console.WriteLine("Ingrese su edad");
            edad= Int32.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine("No es apto para el contenido de este sitio web");
            }

            /* Crear un algoritmo que permita ingresar dos números, si el primer número es mayor al segundo número 
               informar su suma y diferencia, en caso contrario informar el producto y la división del primer número 
               respecto al segundo número.  */

            float num1 = 0;
            float num2 = 0;



            Console.WriteLine("Ingrese el número 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }

            else
            {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }


            /* Un cliente se hospeda varias noches en una hostería, el precio por noche es de 200 dólares. Si el usuario se queda
           más de 3 noches se le aplica un porcentaje de descuento del 17% y si no se aplica un porcentaje de descuento del 2%. 
           Mostrar un mensaje con el monto total que debe pagar el cliente, sabiendo que el usuario indica 
           cuántas noches se va a quedar en la hostería. */

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
                Console.WriteLine($"{nombre}, El total a pagar es: {(precio * noches) * des} dólares");
            }
            else
            {
                Console.WriteLine($"{nombre}, El total a pagar es: {(precio * noches) * cuento} dólares");
            }
        }
    }
}
