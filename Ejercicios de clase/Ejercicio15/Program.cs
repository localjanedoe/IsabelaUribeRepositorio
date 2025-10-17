namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 15. Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, si al final de cada mes 
                   deposita cantidades variables de dinero; además, se quiere saber cuánto lleva ahorrado cada mes. */

            int i = 1;
            int mes = 12;
            int ahorro = 0;
            int acum = 0;

            while (i <= mes)
            {
                Console.WriteLine("Ingrese su ahorro");
                ahorro = Int32.Parse(Console.ReadLine());
                acum = acum + ahorro;
                ++i;
            }
            Console.WriteLine($"El ahorro total del año fue de: {acum}");
        }
    }
}
