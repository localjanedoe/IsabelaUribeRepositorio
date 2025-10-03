namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 7. Escribe un programa que verifique si una persona es mayor de edad usando el operador ternario. 
                  Una persona mayor de edad tiene 18 años o más).  */
            
            int edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine(edad >= 18 ? "Es mayor de edad" : "NO es mayor de edad");
        }
    }
}
