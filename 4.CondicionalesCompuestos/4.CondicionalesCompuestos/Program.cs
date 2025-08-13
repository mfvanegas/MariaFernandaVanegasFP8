using System.ComponentModel.Design;

namespace _4.CondicionalesCompuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos. De lo contrario mostrar el mensaje “Persona exenta de impuestos”.*/

            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre)");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo");
            sueldo = Int32.Parse(Console.ReadLine());

            if (sueldo >= 3000)
            {
                //Verdadero
                Console.WriteLine($"La personas {nombre} , no debe abonar impuestos");
            }
            else
            {
                //Falsa
                Console.WriteLine($"La persona {nombre} , debe abona impuestos");
            }

            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”. De lo contrario, mostrar el mensaje “No es apto para el contenido de este sitio web”.  */
            int edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad = Int32.Parse(Console.ReadLine());
            
            if(edad>=18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine("No es apto para el contenido de este sitio web");
            }

            /*Crear un algoritmo que permita ingresar dos números, si el primer número es mayor al segundo número informar su suma y diferencia, en caso contrario informar el producto y la división del primer número respecto al segundo número.*/
            int numero1 = 0;
            int numero2 = 0;
            Console.WriteLine("Ingrese el primer numero");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            numero2 = int.Parse(Console.ReadLine());

            if(numero1>numero2)
            {
                int numero3 = numero1 + numero2;
                Console.WriteLine($"La suma es {numero3}");
                int numero4 = numero1 - numero2;
                Console.WriteLine($"La diferencia es {numero4}");
            }
            else
            {
                int numero5 = numero1 * numero2;
                Console.WriteLine($"La multiplicacion es {numero5}");
                int numero6 = numero1 / numero2;
                Console.WriteLine($"la division es {numero6}");
            }
        }
    }
}

