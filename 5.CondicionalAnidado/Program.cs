namespace _5.CondicionalAnidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, num3 = 0;
            Console.WriteLine("Ingrese el número 1:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número 2:");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número 3:");
            num2 = Int32.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"Número 1: {num1}, es el mayor");
                }
                else
                {
                    Console.WriteLine($"Número 3: {num3}, es el mayor");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"Número 2: {num2}, es el mayor");
                }
                else
                {
                    Console.WriteLine($"Número 3: {num3}, es el mayor");
                }
            }
        }
    }
}

