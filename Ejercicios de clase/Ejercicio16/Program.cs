namespace Ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
