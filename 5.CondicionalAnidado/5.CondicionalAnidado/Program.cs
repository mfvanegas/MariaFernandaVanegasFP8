﻿namespace _5.CondicionalAnidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Diseñar un algoritmo que lea tres números A, B, C y visualice en pantalla el valor más grande. El usuario debe ingresar tres valores diferentes. */

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese el número 1;");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2:");
            num2=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 3:");
            num3 = Int32.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"el número {num1}, es el mayor");

                }
                else
                {
                    Console.WriteLine($"el número {num3}, es el mayor");
                }
            }
            else
            { 
              if(num2>num3)
              {
                    Console.WriteLine($"el número {num2}, es el mayor");
              }
              else
              {
                    Console.WriteLine($"el número {num3}, es el mayor");

              }
            }

        }
    }
}
