using System.Runtime.ExceptionServices;

namespace _25.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // Arreglos Bidimensionales - Matrices

            int[,] numeros = new int[2,2];        // Rango FxC: 2x2=4
            char[,] caracteres = new char[2,4];
            bool[,] banderas = new bool[2,5];
            object[,] objetos = new object[2,5];

          // Asignación de valores con F, C

            numeros[0, 0] = 15;
            numeros[0, 1] = 25;
            numeros[1, 0] = 32;
            numeros[1, 1] = 4;
            // numeros[1, 2] = 7; ESTÁ FUERA DEL RANGO

          // Recuperamos los datos almacenados
            Console.WriteLine($"Valor almacenado en la posición con índices (1,0): {numeros[1,0]}");


         // Declaración e inicialización de matrices con valores por defecto

            string[,] apellidos =
            {   //F y C son =
                {"Chica","López", "Álvarez" },
                {"Patiño", "Ciro", "Botero"},
                {"Duque", "Carmona", "Castaño"}
            };

            // Recorrer para almacenar datos

            string[,] nombres = new string[3, 2];
            for (int i = 0; i < 3  ; i++)       // Recorrer cada fila
           {
                for (int j = 0; j < 2  ; j++)  // Recorrer las columnas
                {
                    Console.WriteLine($"Digite el nombre para almacenarlo en la posición con índices {i}, {j}");
                    nombres[i, j] = Console.ReadLine();

                }
           }

            // Recorrer para recuperar los datos

            for (int i = 0 ; i < nombres.GetLength(0) ; i++) //Devuelve el número de filas de la matriz
            {
                for (int j = 0 ;j < nombres.GetLength(1) ; j++) // Devuelve el número de columnas de la matriz
                {
                    Console.WriteLine($"Nombre almacenado en la posición {i}, {j}: {nombres[i,j]}");
                }
            }


        }
    }
}
