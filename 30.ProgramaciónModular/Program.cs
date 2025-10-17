namespace _30.ProgramaciónModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplosDe5 = new int[CapturarFilas(), CapturarColumnas()];
            BorrarPantalla();
            LLenarMatriz(multiplosDe5);
            MostrarMatriz(multiplosDe5);

        }

        // Módulo - procedimiento que borra lo que hay en la consola
        static void BorrarPantalla()
        {
            Console.Clear();
        }

        // Módulo - Procedimiento que recibe la matriz que se muestra en pantalla
        static void MostrarMatriz(int [,] matriz)
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

        // Módulo - Función que recibe la matriz a llenar y la devuelve con múltiplos de 5
        static int[,] LLenarMatriz (int [,] matriz)
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
            } return matriz;
        }

        //Módulo - Función que comprueba que el número es múltiplo de 5
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


        //Módulo - Función que le pregunta al usuario por el número de filas de la matriz y las devuelve
        static int CapturarFilas()
        {
            Console.WriteLine("Ingrese el número de filas para la matriz");
            int filas = Int32.Parse(Console.ReadLine());
            return filas;
        }

        // Módulo - Función que le pregunta al usuario por el número de columas de la matriz y las devuelve
        static int CapturarColumnas()
        {
            Console.WriteLine("Ingrese el número de columnas para la matriz");
            int columnas = Int32.Parse(Console.ReadLine());
            return columnas;
        }

    }
}
