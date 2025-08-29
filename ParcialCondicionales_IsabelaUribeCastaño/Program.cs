using System.Net.Http.Headers;

namespace ParcialCondicionales_IsabelaUribeCastaño
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Una empresa de entretenimiento cuenta con 5 salas de juegos, a las que los usuarios pueden acceder dependiendo de su edad.
             * Cada sala ofrece juegos específicos y el precio varía según el juego seleccionado.

            1. Desarrollar un programa en C# que permita realizar las siguientes funciones (70%):
               Solicitar al usuario su edad. Determinar y mostrar las salas a las que puede acceder según su edad, +
               aplicando las siguientes reglas:

             *  1 < edad <= 5 : Sala 1
             *  6 < edad <= 16 :  Sala 2
             *  17 < edad <= 25 : Sala 3 y Sala 4
             *  edad > 26 : Sala 5
         
            Permitir al usuario seleccionar una sala de entre las habilitadas según su edad.
            Mostrar los juegos disponibles en la sala seleccionada, según la siguiente distribución:

            Sala 1 = Juego1, Juego5
            Sala 2 = Juego3, Juego6
            Sala 3 = Juego2, Juego7
            Sala 4 = Juego4, Juego8
            Sala 5 = Juego9, Juego10

            Permitir al usuario seleccionar un juego de los disponibles en la sala elegida.
            Calcular el precio a pagar por el juego seleccionado, según la siguiente tabla de precios:

            Juego1, Juego10           precio: $3.000
            Juego2, Juego9            precio: $5.000
            Juego3, Juego5, Juego8    precio: $7.000
            Juego4, Juego6            precio: $9.000
            Juego7                    precio: $10.000

         Mostrar un mensaje final con los siguientes datos:
         Edad del usuario, Sala seleccionada, Juego seleccionado, Precio a pagar.

         Crear los casos de prueba, y realizar la prueba de escritorio. (30 %). */

            int edad = 0;
            int sala= 0;
            int game = 0;
            int juego = 0;

            Console.WriteLine("Ingrese su edad");
            edad = Int32.Parse(Console.ReadLine());

            if (edad<17)
            {
                if (edad <= 5)
                {
                    sala = 1;
                    Console.WriteLine("Tiene permitido ir a la sala 1");
                    Console.WriteLine($"La sala 1 ofrece los siguientes juegos con sus respectivos precios, escoja el de su gusto."  +
                        $"Juego 1 = $3.000" +
                        $"Juego 5 = $7.000");

                    game = Int32.Parse(Console.ReadLine());
                    switch (game)
                    {
                        case 1: 
                            juego = 3000;
                            Console.WriteLine($"El juego escogido es el 1, El total a pagar es: {juego}");
                            break;
                        case 5: 
                            juego = 7000;
                            Console.WriteLine($"El juego escogido es el 5, El total a pagar es {juego}");
                            break;
                    }
                }
                else
                {
                    sala = 2;
                    Console.WriteLine("Tiene permitido ir a la sala 2");
                    Console.WriteLine($"La sala 2 ofrece los siguientes juegos con sus respectivos precios, escoja el de su gusto." 
                        +
                        $"Juego 3 = $7.000" 
                        +
                        $"Juego 6 = $9.000");

                    game = Int32.Parse(Console.ReadLine());
                    switch (game)
                    {
                        case 3:
                            juego = 7000;
                            Console.WriteLine($"El juego escogido es el 3, El total a pagar es: {juego}");
                            break;
                        case 6:
                            juego = 9000;
                            Console.WriteLine($"El juego escogido es el 6, El total a pagar es: {juego}");
                            break;
                    }
                }

            }
            else
            {
                if (edad <= 25)
                {
                    Console.WriteLine("Tiene permitido ir a las salas 3 y 4. Escoja a la que quiera ir");
                    sala = Int32.Parse(Console.ReadLine());

                    if (sala == 3)
                    {
                        sala = 3;
                        Console.WriteLine("Escogió la sala 3");
                        Console.WriteLine($"La sala 3 ofrece los siguientes juegos con sus respectivos precios, escoja el de su gusto."
                       +
                       $"Juego 2 = $5.000" 
                       +
                       $"Juego 7 = $10.000");

                        game = Int32.Parse(Console.ReadLine());
                        switch (game)
                        {
                            case 2:
                                juego = 5000;
                                Console.WriteLine($"El juego escogido es el 2, El total a pagar es: {juego}");
                                break;
                            case 7:
                                juego = 10000;
                                Console.WriteLine($"El juego escogido es el 7, El total a pagar es: {juego}");
                                break;
                        }

                    }
                    else
                    {
                        sala = 4;
                        Console.WriteLine("Escogió la sala 4");
                        Console.WriteLine($"La sala 4 ofrece los siguientes juegos con sus respectivos precios, escoja el de su gusto."  
                       +
                       $"Juego 4 = $9.000" 
                       +
                       $"Juego 8 = $7.000");

                        game = Int32.Parse(Console.ReadLine());
                        switch (game)
                        {
                            case 4:
                                juego = 9000;
                                Console.WriteLine($"El juego escogido es el 4, El total a pagar es: {juego}");
                                break;
                            case 8:
                                juego = 7000;
                                Console.WriteLine($"El juego escogido es el 8, El total a pagar es: {juego}");
                                break;
                        }
                    }

                }

                else
                {
                    sala = 5;
                    Console.WriteLine("Tiene permitido ir a la sala 5");
                    Console.WriteLine($"La sala 5 ofrece los siguientes juegos con sus respectivos precios, escoja el de su gusto." 
                       +
                       $"Juego 9 = $5.000" 
                       +
                       $"Juego 10 = $3.000");

                    game = Int32.Parse(Console.ReadLine());
                    switch (game)
                    {
                        case 9:
                            juego = 5000;
                            Console.WriteLine($"El juego escogido es el 3, El total a pagar es: {juego}");
                            break;
                        case 10:
                            juego = 3000;
                            Console.WriteLine($"El juego escogido es el 10, El total a pagar es: {juego}");
                            break;
                    }
                }
            }

            Console.WriteLine($"Datos del usuario:" 
                +
                $"Edad: {edad}" 
                +
                $"Sala escogida: {sala}" 
                +
                $"Juego escogido: {game}" 
                +
                $"Precio a pagar: {juego}");
            
        }
    }
}
