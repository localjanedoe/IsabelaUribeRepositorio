namespace _10.While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /* 10. Crear un algoritmo que permita calcular la factorial de un número dado por el usuario */

            int acum = 1;
            int contador = 1;
            int num = 0;

            Console.WriteLine("Ingrese el número el cuál desea saber su factorial");
            num = Int32.Parse(Console.ReadLine());

            while (contador <= num)
            {
                acum *= contador;
                contador++;
            }

            Console.WriteLine($"El factorial de {num} es {acum}");

            /* 11. Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. 
                   Se debe mostrar por pantalla el total de la suma de los números ingresados.  */

            int numero = 0;
            int acumul = 0;
            int j = 0;

            while (numero >=0)
            {
                Console.WriteLine("Ingrese un número entero positivo");
                numero = Int32.Parse(Console.ReadLine());
                acumul = acumul + numero;
                Console.WriteLine ($"{acumul}");
                j++;
             
            }

           /* 12. Realizar algoritmo que permita obtener la suma de todos los números impares hasta el 99. */

            int number = 0;
            int acumulador = 0;
            int i = 1;

            while (number <=99)
            {
                if (number % 2 != 0)
                {
                    acumulador += number;
                    Console.WriteLine($"{acumulador}");
                }
                number++;
            }
            
        }
    }
}
