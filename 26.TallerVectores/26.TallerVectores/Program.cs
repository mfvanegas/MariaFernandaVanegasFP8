using System.Numerics;

namespace _26.TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego 
             * encuentre y muestre el valor máximo y mínimo de los números ingresados. 

            int[] vector; //Declarando

            vector = new int[15]; //Inicializando
            int mayor = 0;
            int menor = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese el número entero para la posción {i + 1}, con índice {i}: ");
                vector[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    mayor = vector[i];
                    menor = vector[i];
                }
                else
                {
                    if (vector[i] > mayor)
                    {
                        mayor = vector[i];
                    }
                    if (vector[i] < menor)
                    {
                        menor = vector[i];
                    }
                }
            }
            Console.Clear();

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " |");
            }
            Console.WriteLine($"\n El número mayor es: {mayor}, el número menor es: {menor}");*/

            /*Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta 
             * el orden de los elementos del vector. Se deben mostrar lo dos vectores.*/

            int rango = 0;
            Console.WriteLine("Ingrese el rango de caracteres que desea:");
            rango = int.Parse(Console.ReadLine());

            char[] caracteres = new char[rango];

            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.WriteLine($"Ingrese el caracter para la posción {i + 1}, con índice {i}: ");
                caracteres[i] = char.Parse(Console.ReadLine());
            }

            char[] invertido = new char[rango];
             
            for (int i = 0; i < invertido.Length; i++)
            {

                invertido[i] = caracteres[rango - 1 - i];
            }
            
            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.Write(caracteres[i] + " |");
            }
            Console.WriteLine();
            for (int i = 0; i < invertido.Length; i++)
            {
                Console.Write(invertido[i] + " |");
            }
            Console.WriteLine();
        }
    }
}
