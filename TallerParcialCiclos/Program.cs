namespace TallerParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*    1.   Algoritmo que permita calcular el promedio de calificaciones, el algoritmo le permitirá al usuario, 
                       introducir tantas calificaciones como así desee, en el momento en que seleccione que no desea continuar 
                       capturando calificaciones, el algoritmo debe presentar el promedio de las calificaciones capturadas previamente. */

            int totalNotas = 1;
            int notas = 0;
            float prom = 0f;
            char response = ' ';
            int acum = 0;

            do
            {
                Console.WriteLine($"Ingrese la nota no. {totalNotas}");
                notas = Int32.Parse(Console.ReadLine());
                acum += notas;
                totalNotas++;
                Console.WriteLine("¿Desea registrar otra nota? s:Sí n:No ");
                response = Convert.ToChar(Console.ReadLine());

            } while (response == 's');
            prom = acum / totalNotas;
            Console.WriteLine($"El promedio de notas es de {prom}");


         /*    2.   Se requiere un algoritmo para mostrar por pantalla los divisores de un número ingresado por teclado. Tener en cuenta 
                    que dados dos números enteros a y b, se dice que b es  divisor de a si se cumple que al efectuar una división entera a/b el 
                    residuo es 0, en C# utilizar el operador Mod para obtener el residuo de una división de dos números. 

                   Ejemplo:  Si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 2, 1 que son los divisores del número 6.  */







         /*    3.  Dados dos números enteros ingresados por teclado: b que es la base y  e que es el exponente, se requiere calcular 
                   el resultado de la potenciación.  
             
                   Ejemplo: b=2, e=5  25=2*2*2*2*2= 32 
   
                   Mostrar por pantalla el resultado de la potenciación. Seguir pidiendo por teclado la base y el exponente y realizar la 
                   potenciación correspondiente, hasta que el usuario ingrese por teclado el carácter de escape ‘n’  */

         /*    4.  Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco kilómetros durante 10 días, para determinar si es apto 
                  para la prueba de 5 kilómetros. Para considerarlo apto debe cumplir las siguientes condiciones: 
             
                  *  Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos. 
                  *  Que al menos en una de las pruebas realice un tiempo menor de 15 minutos. 
                  *  Que su promedio sea menor o igual a 18 minutos. 
   
                 Diseñar un algoritmo para registrar los datos y decidir si es apto para la competencia.     */
            

         /*    5.  Se aplicó una encuesta a N personas solicitando su opinión sobre el tema del servicio militar obligatorio para las mujeres. 
                 Las opciones de respuesta fueron: 
                 * A favor 
                 * En contra 
                 * No responde 
                 
                 Se solicita un algoritmo que calcule qué porcentaje de los encuestados marcó cada una de las respuestas.    */


         /*    6.  Realizar un algoritmo que lea 40 números e imprima en pantalla cuántos  de esos números son positivos, cuántos negativos, 
                 cuántos son neutros (0); además que imprima por pantalla la sumatoria de los números positivos y la de los negativos.  */


         /*    7.  Una persona desea realizar un muestreo con 70 personas para determinar el promedio de peso de los niños, jóvenes, adultos 
                 y viejos que existen en su zona y cuántos son de cada una de las categorías. 
                 
                 Las categorías están dadas por la siguiente tabla: 
          
                        Categoría      Edad 
                          Niños        0-13 
                         Jóvenes       14-30 
                         Adultos       31-60 
                         Viejos        61 en adelante        
         */

         /*   8.  El Departamento de Transito de Antioquia. desea saber de los n autos  que entran a la ciudad de Medellín, cuántos autos 
                entran con una calcomanía de un determinado color. Conociendo el último dígito de la placa de cada automóvil se puede 
                determinar el color de la calcomanía, para determinar lo anterior utilice la siguiente tabla: 
                        
                        DÍGITO         COLOR 
                        1 o 2          amarilla 
                        3 o 4          rosa 
                        5 o 6          roja 
                        7 o 8          verde 
                        9 o 0          azul

         */
        }
    }
}
