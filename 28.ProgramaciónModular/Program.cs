namespace _28.ProgramaciónModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensajes("Soy Isabela");
            MostrarMensajes("No tengo boca y debo gritar");
            MostrarMensajes($"Tengo {CalcularEdad()} años");
            MostrarMensajes($"Tengo {CalcularEdad(2025, 2007)} años");
        }

        // Módulo 1 - Procedimiento sin parámetros
        static void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido a la Programación Modular");
            MostrarMensajes("Estoy hablando desde MostrarMensajes");
        }

        // Módulo 2 - Procedimiento con parámetros
        static void MostrarMensajes(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        // Módulo 3 - Función sin parámetros
        static int CalcularEdad()
        {
            int edad = 2025 - 2007;
            return edad;
        }

        // Módulo 4 - Función con parámetros
        static int CalcularEdad (int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }
    }
}
