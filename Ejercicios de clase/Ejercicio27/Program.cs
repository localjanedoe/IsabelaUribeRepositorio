using System.Runtime.ConstrainedExecution;

namespace Ejercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  27. Desarrolla una aplicación que realice las siguientes tareas:

               1. Solicita al usuario que ingrese las dimensiones de una matriz(número de filas y columnas). 

               2. Recorre la matriz y permite al usuario ingresar un número entero en cada posición. 

               3. Una vez cargada la matriz, el programa debe contar cuántos de los números ingresados son positivos, 
                  cuántos son negativos y cuántos son ceros.

               4. Finalmente, muestra por pantalla los totales obtenidos para cada categoría(positivos, negativos y ceros).  */

            int F = 0;
            int C = 0;

            Console.WriteLine("Ingrese el número de filas");
            F = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columnas");
            C = Int32.Parse(Console.ReadLine());    
           
            int[,] numeros = new int[F, C];

            for (int i = 0; i < F; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    
                }
            }
        }
    }
}
