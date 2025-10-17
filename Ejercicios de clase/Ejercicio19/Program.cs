namespace Ejercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 19. En un grupo de 100 alumnos, se desea saber cuántos de los estudiantes son hombres y cuántos son mujeres, 
                   además se desea saber cuántos son mayores de edad y cuántos no.  */

            int estudiantes = 1;
            int genero = 0;
            int mujeres = 0;
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

        }
    }
}
