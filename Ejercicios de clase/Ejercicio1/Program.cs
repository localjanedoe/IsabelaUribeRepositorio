namespace Ejercicio1
{
    internal class Program
    {
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
