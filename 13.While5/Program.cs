using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _13.While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 13. Escribir un algoritmo que cuente cuántos números pares hay
                   en un rango de números del 1 al número n.  */

            int rango = 0;
            int cantidadPares = 0;
            int count = 1;

            Console.WriteLine("Ingrese la cantidad de números a evaluar");
            rango = Int32.Parse(Console.ReadLine());

            while (count <= rango)
            {
                if (count % 2 == 0)
                {
                    cantidadPares++;
                }
                count++;
            }
            Console.WriteLine($"La cantidad de pares entre 1 y {rango} es: {cantidadPares}");



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


            /* 16. Escribe un algoritmo en el que el ordenador elija un número aleatorio entre 1 y 100. El usuario debe adivinar 
                   el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. 
                   Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número.  */

            int numero;
            int playerGuess = 0;
            Random rnd = new Random();
            numero = rnd.Next(0, 101);    //Devuelve un número entre 1 y 100

            while (playerGuess != numero)
            {
                Console.WriteLine("Intente adivinar el número");
                playerGuess = Int32.Parse(Console.ReadLine());

                if (playerGuess < numero)
                {
                    Console.WriteLine("Intento demasiado bajo");
                }
                if (playerGuess > numero)
                {
                    Console.WriteLine("Intento demasiado alto");
                }
                if (playerGuess == numero)
                {
                    Console.WriteLine("¡Acertaste!");
                }
            }
            

        }
    }
}
