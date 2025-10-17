namespace Ejercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
