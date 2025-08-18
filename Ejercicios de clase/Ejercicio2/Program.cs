namespace Ejercicio2
{
    internal class Program
    {
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
