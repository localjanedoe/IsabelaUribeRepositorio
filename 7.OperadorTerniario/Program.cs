namespace _7.OperadorTerniario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operador Terniario

            /*Escriba un programa que verifique si una persona
              es mayor de edad usando el operador ternario. Una
              persona mayor de edad tiene 18 años o más*/

            int edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine(edad >= 18 ? "Es mayor de edad" : "NO es mayor de edad");

            /* Cree un algoritmo que permita ingresar 3 números enteros diferentes, y
              muestre mensaje diciendo cuál es el mayor*/

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int mayor = 0;
            Console.WriteLine("Ingrese su primer número");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su segundo número");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tercer número");
            num3 = Int32.Parse(Console.ReadLine());
            mayor = num1 > num2
                     ? (num1 > num3 ? num1 : num3)
                     : (num2 > num3 ? num2 : num3);
            Console.WriteLine($"El número mayor es {mayor}");

        }
    }
}
