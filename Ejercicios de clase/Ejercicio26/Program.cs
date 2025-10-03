namespace Ejercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  26. Escribe un programa que realice la suma de dos matrices de dimensiones 2x3. 
                    Requisitos del programa: 

              * Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas. 
              * Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones (2x3). 
              * Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices. 
              * Muestra la matriz resultante de la suma en formato de matriz (2 filas, 3 columnas).  
              */

            int[,] numeros1 = new int[2, 3];
            int[,] numeros2 = new int[2, 3];
            

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese los datos de la primera matriz en el índice: {i}, {j}");
                    numeros1[i,j] = Int32.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese los datos de la segunda matriz en el índice: {i}, {j}");
                    numeros2[i,j] = Int32.Parse(Console.ReadLine());
                }
            }

            int F = numeros1.GetLength(0);
            int C = numeros1.GetLength(1);

            int[,] sumaMatrices = new int[F, C];

            for (int i = 0; i < 2; i++)
            {
                for ( int j = 0; j < 3; j++)
                {
                    sumaMatrices[i,j] = numeros1[i,j] + numeros2[i,j];
                }
            }

            for (int i = 0; i < F; i++)
            {
                for( int j = 0; j < C; j++)
                {
                    Console.WriteLine($"La matriz resultante es: {sumaMatrices[F,C]}");
                }
            }
            
        }
    }
}
