using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParcialArreglos_IsabelaUribe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*      Análisis numérico de una matriz dinámica

              Implemente un programa que permita a un usuario definir, llenar y analizar una matriz de números enteros, con el objetivo 
              de obtener estadísticas numéricas específicas.

              Requisitos del programa: 

              Definición de la matriz: Solicite al usuario ingresar el número de filas n y columnas m de la matriz. Ambos valores deben 
              ser enteros mayores o iguales a 2 y menores o iguales a 10. Si el usuario ingresa valores fuera del rango, debe 
              mostrarse un mensaje de error y volver a solicitar la entrada.


              Ingreso de elementos: Permita al usuario ingresar los elementos de la matriz manualmente, uno a uno, indicando la posición 
              actual (fila, columna). Cada número debe ser un entero que puede ser positivo, negativo o cero.

              Visualización de la matriz: Una vez completado el ingreso, mostrar la matriz en pantalla con un formato tabular.

              Procesamiento y estadísticas: Calcular y mostrar en pantalla lo siguiente:
             *  La suma de todos los números pares ingresados en la matriz.
             *  La suma de todos los números impares.
             *  La cantidad de números negativos encontrados en la matriz.
             *  La cantidad total de ceros.
             *  El promedio general de todos los valores ingresados.

            Formato de salida: Cada resultado debe mostrarse con un mensaje descriptivo.
            Consideraciones técnicas:  El cálculo del promedio debe considerar todos los elementos de la matriz. */

            int n = 0;
            int m = 0;
            int acumCeros = 0;
            int acumPares = 0;
            int acumImpares = 0;
            int acumNegativos = 0;
            int promGeneral = 0;
            int acum= 0;

            int[,] numeros = new int[n, m];
            int[,] suma = new int[n, m];
            int elementos = 0;

            Console.WriteLine("Ingrese el número de filas");
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columnas");
            m = Int32.Parse(Console.ReadLine());

            if (n > 10 || m > 10)
            {
                if ( n < 2 || m < 2)
                {
                    Console.WriteLine("Error. Ingrese de nuevo");
                }
            }

            else
            {
                elementos++;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.WriteLine($"Ingrese los datos de la posición: {i}, {j}");
                        numeros[i, j] = Int32.Parse(Console.ReadLine());
                       

                        

                        if (numeros[i, j] < 0)
                        {
                            acumNegativos++;
                        }

                        if (numeros[i, j] == 0)
                        {
                            acumCeros++;
                        }

                        if ((numeros[i, j]) % 2 != 0)
                        {
                            acumImpares += numeros[i, j];
                        }

                        if ((numeros[i, j]) % 2 == 0)
                        {
                            acumPares += numeros[i, j];
                        }

                        promGeneral = acum / elementos;
                    }
                }

                Console.WriteLine($"La suma de todos los pares es: {acumPares} ");
                Console.WriteLine($"La suma de todos los impares es: {acumImpares} ");
                Console.WriteLine($"La cantidad de negativos en la matriz es: {acumNegativos} ");
                Console.WriteLine($"La cantidad de ceros en la matriz es de: {acumCeros} ");
                Console.WriteLine($"El promedio general de la matriz es: {promGeneral} ");
            }
              
            

        }
    }
}
