using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
                  numero2, numero3 respectivamente.El algoritmo debe comprobar si los números son
                  diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
                  pantalla los números de menor a mayor. */

          /*  2.  El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: 
           *  Si cuenta con munición 
           *  Si se encuentra en estado invencible, crear un programa que: 
           a. Permita ingresar por teclado si el personaje está en estado invencible(True).
           b. La cantidad de munición que tiene el personaje en el momento será calculada por el
              sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#. 
          Ejemplo:
            int numero;
            Random rnd = new Random();
            numero = rnd.Next(1, 6);//Devuelve un número entre 0 y 5 
            Console.WriteLine(numero);

            c. Si el estado del personaje es invencible(true) y su cantidad de munición está entre 1 y
            10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario
            no hacer nada.
           
            3.Crear un algoritmo que permita ingresar las coordenadas x, y, para tres puntos: P1(x1, y1), 
              P2(x2, y2), P3(x3, y3).Luego calcular la distancia entre los puntos P1  P2, P2  P3, P1 
              P3.La distancia entre dos puntos está dada por la siguiente formula:
               d = √((x2 - x1)² +(y2 - y1)²) 

             Después de haber calculado la distancia entre los puntos, el algoritmo debe decir si con
             dichas distancias se puede construir un triángulo, consultar las condiciones que se deben
             cumplir para realizar dicha construcción.En caso contrario, decir cuál o cuáles de las
             condiciones no se cumplen. 

           4. El personaje de un juego, solo se puede mover en forma horizontal(Izquierda o Derecha), 
              crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve
              hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado.

             * Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la derecha
             * Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la derecha
             * En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra dirección” 
             
           5. El personaje de un juego, puede realizar diferentes acciones dependiendo del carácter que
              el usuario ingrese, y de la cantidad de vidas que posee.Crear un programa que permita:
            
           * Generar un número aleatorio entre 0 y 5 para simular el número de vidas del personaje.  (Función Random) 
           * Si el número de vidas es mayor a 0, el personaje puede realizar acciones en el juego. 
           * En caso contrario escribir el mensaje “el personaje no posee vidas, y no puede realizar
             ninguna acción”. 
           * Si el personaje puede realizar acciones, escribir los siguientes mensajes de acuerdo al
             carácter que se ingrese: 
            
            o Si se ingresa ‘c’, mostrar en consola “el personaje está disparando” 
            o Si se ingresa ‘x’, mostrar en consola “el personaje está hablando con la Rana” 
            o Si se ingresa ‘t’, mostrar en consola “el personaje está en modo Turbo” 
            o Si se presiona ‘i’, mostrar en consola “el personaje es Invencible” 

          6. Realizar la prueba de escritorio para el siguiente algoritmo, según los casos propuestos a
             continuación.
             Caso1: finalProm > 0
             Caso2: finalProm = 20
             Caso3: finalProm = 15
             Caso4: finalProm <= 0 */
        }
    }
}
