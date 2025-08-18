using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES
            //Operadores numéricos, cambio de signo

            int num1 = 5;
            int num2 = -num1;
            int num3 = +num2;
            int num4 = -num3;

            Console.WriteLine($"{num1}//{num2}//{num3}//{num4}");

            //Operadores Aritméticos
            int num5 = 3 + 5; //Suma
            int num6 = 100 - 26; //Resta
            int num7 = 4 * 2; //Multiplicación
            float num8 = (float)5 / 3; //División
            // también es válido float num8 = 5f / 3f;
            double num9 = 5d / 3;
            decimal num10 = 5 / 3m;
            Console.WriteLine($"suma: {num5}, resta:{num6}, multiplicación:  {num7}, división: {num8}, {num9}, {num10}");

            // Operadores de Incremento (++) y decremento (--)
            num1++; //num1 = num1 + 1; Incremento
            num2--; //num2 = num2 - 1; Decremento
            num3 += 5; //num3 = num3 + 5;
            num4 -= 20; //num4 = num4 - 20;
            num5 *= 31; // num5 = num5 * 31;
            num7 /= num1; //num7 = num7 / num1;

            //Orden de evaluación operadores aritméicos
            int num11 = 4 * 3 / 2;      // * , /
            int num12 = 4 / 3 * 2;      // /, *
            int num13 = (4 * 3) / 6;    // (), /
            int num14 = 4 * (3 / 2);    // (), *
            int num15 = 4 + 6 * 3;     // *, +
            int num16 = 4 + 6 * (2 - 1) / 2;  // (), *, /, +

            Console.WriteLine($"{num11}, {num12}, {num13}, {num14}, {num15}, {num16}");

            //Operadores Lógicos
            //Conjunción - AND - &&
            Console.WriteLine("TABLA DE VERDAD CONUNCIÓN");
            Console.WriteLine($"V && V = {true && true}");
            Console.WriteLine($"V && F = {true && false}");
            Console.WriteLine($"F && V = {false && true}");
            Console.WriteLine($"F && F = {false && false}");

            //Operadores Lógicos
            //Disyunción - OR - ||
            Console.WriteLine("TABLA DE VERDAD DISYUNCIÓN");
            Console.WriteLine($"V && V = {true || true}");
            Console.WriteLine($"V && F = {true || false}");
            Console.WriteLine($"F && V = {false || true}");
            Console.WriteLine($"F && F = {false || false}");

            bool exp1 = true;
            bool exp2 = false;
            bool exp3 = exp1 && exp2;
            bool exp4 = exp2 || exp3;
            bool exp5 = !exp4 || exp2;

            Console.WriteLine($"{exp1}, {exp2}, {exp3}, {exp4}, {exp5}");

            // OPERADORES DE COMPARACIÓN
            bool exp6 = 5 > 4;
            bool exp7 = 5 >= 5;
            bool exp8 = 100 == 102;
            bool exp9 = 100 != 102;
            bool exp10 = 5 > 4 && 2 < 3;
            Console.WriteLine($"{exp6}, {exp7}, {exp8}, {exp9}, {exp10}");
            bool exp11 = 5 > 4 || !exp4;
        }



    }
}

