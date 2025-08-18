namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroA = 0;
            int numeroB = 0;
            int numeroC = 0;
            int prom = 0;
            

            Console.WriteLine("Ingrese el número A");
            numeroA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número B");
            numeroB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número C");
            numeroC = Convert.ToInt32(Console.ReadLine());

            if (numeroA > numeroB) 
            {  
                if (numeroA > numeroC)
                {
                    Console.WriteLine($"El número A: {numeroA} es el mayor");
                }
                else
                {
                    Console.WriteLine($"El número C: {numeroC} es el mayor");
                }
            }
            else
            {
                if (numeroB > numeroC)
                {
                    Console.WriteLine($"El número B: {numeroB} es el mayor");
                }
                else
                {
                    Console.WriteLine($"El número C: {numeroC} es el mayor");
                }
            }

            Console.WriteLine($"{(prom)= (numeroA + numeroB + numeroC)/3} ");

            if (prom < 10)
            {
                if (prom >= 9.5)
                {
                    Console.WriteLine($"El promedio es {prom}: Excelente");
                }
                else
                {
                    if (prom >= 8.5)
                    {
                        Console.WriteLine($"El promedio es {prom}: Muy bueno");
                    }
                    else
                    {
                        if (prom >= 7.5)
                        {
                            Console.WriteLine($"El promedio es {prom}: Bueno");
                        }
                        if (prom >=6.5)
                        {
                            Console.WriteLine($"El promedio es {prom}: Regular");
                        }
                        if (prom < 6)
                        {
                            Console.WriteLine($"El promedio es {prom}: Bajo");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Error.");
            }
        }
    }
}
