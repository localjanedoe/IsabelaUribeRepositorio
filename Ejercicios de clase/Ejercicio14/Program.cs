namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 14. Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. 
                   Al usuario le corresponde ingresar la cantidad de números que va a introducir.  
                   El algoritmo debe escribir en pantalla: 

               * La cantidad de números introducidos que son mayores que 0 
               * La cantidad de números introducidos menores que 0  
               * La cantidad de números iguales a 0. */

            int num = 0;
            int k = 1;
            int range = 0;
            Console.WriteLine("Ingrese la cantidad de números que desee introducir");
            range = Int32.Parse(Console.ReadLine());

            while (k <= range)
            {
                Console.WriteLine("Ingrese un número entero");
                num = Int32.Parse(Console.ReadLine());

                if (num > 0)
                {
                    Console.WriteLine($"{num} > 0");
                }

                if (num == 0)
                {
                    Console.WriteLine($"{num} = 0");
                }

                if (num < 0)
                {
                    Console.WriteLine($"{num} < 0");
                }
                k++;
            }
        }
    }
}
