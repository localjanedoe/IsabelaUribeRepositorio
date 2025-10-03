using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace ParcialCiclosIsabelaUribeCastaño
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   Se requiere diseñar un programa para procesar las notas definitivas de Física de un grupo de 15 estudiantes. 
                 Las calificaciones están en un rango de 0.0 a 5.0. El programa debe realizar las siguientes tareas:

               *   Ingresar por teclado la nota final de cada estudiante.
               *   Calcular el promedio general del grupo.
               *   Clasificar a cada estudiante según su calificación en una de las siguientes categorías:

                   Excelente: nota ≥ 4.8
                   Bueno: 4.0 ≤ nota ≤ 4.7
                   Regular: 3.0 ≤ nota ≤ 3.9
                   Descuidado: nota ≤ 2.9

                Contar y mostrar por pantalla el número total de estudiantes en cada categoría.
                Mostrar en pantalla el promedio del grupo y la cantidad de alumnos clasificados en cada nivel. */

            float notaFinal = 0f;
            float prom = 0f;
            float acum = 0;
            int EE = 0;
            int EB = 0;
            int ER = 0;
            int ED = 0;


            do
            {
                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine("Ingrese su nota final");
                    notaFinal = float.Parse(Console.ReadLine());

                    if (notaFinal >= 4)
                    {
                        if (notaFinal >= 4.8)
                        {
                            EE++;
                        }
                        else
                        {
                            EB++;
                        }
                    }
                    else
                    {
                        if (notaFinal >= 3.0)
                        {
                            ER++;
                        }
                        else
                        {
                            ED++;
                        }
                    }

                    acum += notaFinal;
                }
            } while (notaFinal < 5);

            prom = (acum) /15;
            Console.WriteLine($"El promedio del grupo fue de:       {prom}");
            Console.WriteLine($"Cantidad de estudiantes excelentes:  {EE}");
            Console.WriteLine($"Cantidad de estudiantes buenos:      {EB}");
            Console.WriteLine($"Cantidad de estudiantes regulares:   {ER}");
            Console.WriteLine($"Cantidad de estudiantes descuidados: {ED}");
        }
    }
}
