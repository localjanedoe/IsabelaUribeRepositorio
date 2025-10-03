namespace _22.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arreglos Unidimensionales
            // Vectores
            int[] numeros = new int[5];
            string[] nombres = new string[4];

            // Almacenemos datos 
            numeros[0] = 12;
            numeros[1] = 32;
            numeros[2] = 41;
            numeros[3] = 100;
            numeros[4] = 56;
            //numeros[5] = 0; no existe debido a que está fuera del rango


            // Recuperamos datos
            Console.WriteLine($"El valor almacenado en la posición 4, con índice 3 es: {numeros[3]}");


            // Podemos recorrer para almacenar datos 
            for ( int i = 0; i < 5; i++ )
            {
                Console.WriteLine($"Ingrese el dato almacenado en la posición {i+1} con índice {i}");
                numeros[i] = Int32.Parse(Console.ReadLine());
            }


            // Otras formas de inicializar y declarar vectores
            char[] caracteres = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g'};
            float[] numeros2 = { 0.3f, 1.5f, 2.5f, 4.5f, 0.01f };


            // Recorrer para recuperar datos almacenados
            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.WriteLine($"El carácter almacenado en la posición {i + 1} con índice {i} es {caracteres[i]}");
            }
            for (int i = 0;i < numeros2.Length; i++)
            {
                Console.WriteLine($"{numeros2[i]}");
            }


        }
    }
}
