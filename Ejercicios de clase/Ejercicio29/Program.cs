namespace Ejercicio29
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // 29.Crear una matriz de n filas por m columnas, que permita ingresar solamente múltiplos de 5 hasta que se llene la matriz.
            int[,] multiplosDe5 = new int[CapturarFilas(), CapturarColumnas()];
            BorrarPantalla();
            LLenarMatriz(multiplosDe5);
            MostrarMatriz(multiplosDe5);
        }

        static void BorrarPantalla()
        {
            Console.Clear();
        }

        static void MostrarMatriz(int[,] matriz)
        {
            BorrarPantalla();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"{matriz[i, j]} | ");
                }
            }
        }

        static int[,] LLenarMatriz(int[,] matriz)
        {
            int numero = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    do
                    {
                        Console.WriteLine("Ingrese un numero para almacenar en la matriz");
                        numero = Int32.Parse(Console.ReadLine());

                    } while (EsMultiplo5(numero) == false);
                    matriz[i, j] = numero;
                }
            }
            return matriz;
        }

        static bool EsMultiplo5(int numero)
        {
            if (numero % 5 == 0 && numero != 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error. Debe digitar un múltiplo de 5");
                return false;
            }
        }

        static int CapturarFilas()
        {
            Console.WriteLine("Ingrese el número de filas para la matriz");
            int filas = Int32.Parse(Console.ReadLine());
            return filas;
        }

        static int CapturarColumnas()
        {
            Console.WriteLine("Ingrese el número de columnas para la matriz");
            int columnas = Int32.Parse(Console.ReadLine());
            return columnas;
        }

    }
}
}
