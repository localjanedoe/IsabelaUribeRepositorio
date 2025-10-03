using System.Security.Cryptography;

namespace _17.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escriba un algoritmo que genere y sume los primeros 5 números enteros
            int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador=acumulador+contador;


            } while (contador < 5);

            Console.WriteLine($"La suma de los cinco primeros números enteros es {acumulador}");


            /*  17. Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10.
                    Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar */

            int count = 1;
            int acum = 0;
            int dato = 0;
            string respuesta = "";
            
            do
            {
                Console.WriteLine("Ingrese un número");
                dato = Int32.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine($"{dato} * {count} = {dato * count}");
                    count++;
                } while (count < 11);

                Console.WriteLine("¿Desea generar una nueva tabla de multiplicar? s: sí , n:no");
                respuesta = Console.ReadLine().ToLower();
                count = 1;

            } while (respuesta == "s");

            /* 18. Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; 
                   para cada usuario se debe hacer lo siguiente: 

              * Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, 
                el número de cuenta, el saldo y “Es apto para el crédito” 

              * Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, 
                el número de cuenta, el saldo y “No es apto para el crédito” 

              El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique 
              que ya no se desea preguntar más. Además, el algoritmo debe permitir mostrar el número de usuarios 
              a los que se le pregunto por la información, y debe mostrar el promedio de los saldos. */

            string name = "";
            int numCuenta = 0;
            int saldo = 0;
            int numUsuarios = 0;    
            string noMore = "";

            do
            {
                Console.WriteLine("Ingrese su nombre completo");
                name = Console.ReadLine();
                Console.WriteLine("Ingrese su número de cuenta");
                numCuenta = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su saldo");
                saldo = Int32.Parse(Console.ReadLine());

                if (saldo > 3000000)
                {
                    Console.WriteLine($"Usuario: {name}");
                    Console.WriteLine($"No. de cuenta: {numCuenta}");
                    Console.WriteLine($"Con saldo: {saldo}");
                    Console.WriteLine("Usted es apto para el crédito");
                }
                else
                {
                    Console.WriteLine($"Usuario: {name}");
                    Console.WriteLine($"No. de cuenta: {numCuenta}");
                    Console.WriteLine($"Con saldo: {saldo}");
                    Console.WriteLine("Usted NO es apto para el crédito");


                }
                Console.WriteLine("Desea continuar? O:Sí,  X:No ");
                noMore = Console.ReadLine();
                numUsuarios++;

            } while (noMore == "O");

            /* 19. En un grupo de 100 alumnos, se desea saber cuántos de los estudiantes son hombres y cuántos son mujeres, 
                   además se desea saber cuántos son mayores de edad y cuántos no.  */

            int estudiantes = 1;
            int genero = 0;
            int mujeres= 0;
            int hombres = 0;
            int edad = 0;
            int mayores = 0;
            int menores = 0;
            int cantidad = 5;
       

            do
            {
               Console.WriteLine($"Estudiante no. {estudiantes}");
               Console.WriteLine("Ingrese su género");
               Console.WriteLine("1. Mujer,  2. Hombre");
               genero = Int32.Parse(Console.ReadLine());
               Console.WriteLine("Ingrese su edad");
               edad = Int32.Parse(Console.ReadLine());


               if (genero == 1)
               {
                   mujeres++;
               }

               if (genero == 2)
               {
                   hombres++;
               }

               if (edad >= 18)
               {
                    mayores++;
               }
               else
               {
                    menores++;
               }

                estudiantes++;

            } while (estudiantes < cantidad);

              Console.WriteLine($"Cantidad de mujeres: {mujeres}");
              Console.WriteLine($"Cantidad de hombres: {hombres}");
              Console.WriteLine($"Menores de edad: {menores} ");
              Console.WriteLine($"Mayores de edad: {mayores}");




            /*  20. Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:

            *  El número de partidos perdidos
            *  El número de partidos empatados
            *  El número de partidos ganados
            *  El porcentaje de partidos perdidos
            *  El porcentaje de partidos empatados
            *  El porcentaje de partidos ganados      */

            int partidos = 0;
            int marcadorRival = 0;
            int marcadorEquipo = 0;
            int PP = 0;
            int PE = 0;
            int PG = 0;

            do
            {
                Console.WriteLine("Ingrese los goles hechos por el equipo");
                marcadorEquipo = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese los goles hechos por el equipo rival");
                marcadorRival = Int32.Parse(Console.ReadLine());

                if (marcadorEquipo > marcadorRival)
                {
                    PG++;
                }

                if (marcadorEquipo < marcadorRival)
                {
                    PP++;
                }

                if (marcadorEquipo == marcadorRival)
                {
                    PE++;
                }

            } while (partidos < 30);

            Console.WriteLine($"Partidos ganados:         {PG}");
            Console.WriteLine($"Partidos empatados:       {PE}");
            Console.WriteLine($"Partidos perdidos:        {PP}");
            Console.WriteLine($"Porcentaje de victorias:  {(PG/30) * 100}");
            Console.WriteLine($"Porcentaje de empates:    {(PE/30) * 100 }");
            Console.WriteLine($"Porcentaje de derrotas:   {(PP/30) * 100}");
                
        }
    }
}
