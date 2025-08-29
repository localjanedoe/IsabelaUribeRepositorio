using System.Collections.Specialized;

namespace Ejercicio4
{
    internal class Program
    {

        /* Un cliente se hospeda varias noches en una hostería, el precio por noche es de 200 dólares. Si el usuario se queda
           más de 3 noches se le aplica un porcentaje de descuento del 17% y si no se aplica un porcentaje de descuento del 2%. 
           Mostrar un mensaje con el monto total que debe pagar el cliente, sabiendo que el usuario indica 
           cuántas noches se va a quedar en la hostería. */
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
