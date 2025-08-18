namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            
           
            
            Console.WriteLine("Ingrese el número 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }

            else
            {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
        
        }
    }
}
