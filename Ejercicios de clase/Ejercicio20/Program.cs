namespace Ejercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine($"Porcentaje de victorias:  {(PG / 30) * 100}");
            Console.WriteLine($"Porcentaje de empates:    {(PE / 30) * 100}");
            Console.WriteLine($"Porcentaje de derrotas:   {(PP / 30) * 100}");

        }
    }
}
