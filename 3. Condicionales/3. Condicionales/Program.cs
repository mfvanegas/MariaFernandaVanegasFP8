﻿using System.ComponentModel.Design;

namespace _3.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONDICIONALES SIMPLES
            /* Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona,
            si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, 
            indicando que debe abonar impuestos. */

            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine(); //Todo lo que se lee desde la consola llega como string 
            Console.WriteLine("Ingrese el sueldo");
            sueldo = Convert.ToInt32(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");

            }


            /*2. Crea un algoritmo que lea la edad de un usuario, 
            si el usuario es mayor de 18, se debe mostrar 
            el siguiente mensaje: “Bienvenido a mi sitio web” Ejercicio pendiente.*/ 

            int edad = 0;

            Console.WriteLine("Ingrese la edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad > 18) ;
            {
                Console.WriteLine($"La persona de edad {edad} es bienvenido a mi sitio web");

            }





        }

    }
}