namespace Ejercicio2
{
    internal class Program
    {
        /* Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar 
          el siguiente mensaje: “Bienvenido a mi sitio web”. De lo contrario, mostrar el mensaje 
          “No es apto para el contenido de este sitio web” */
        static void Main(string[] args)
        {
            int edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido al sitio web");
            }
            else
            {
                Console.WriteLine("No es apto para el contenido de este sitio web");
            }
        }
    }
}
