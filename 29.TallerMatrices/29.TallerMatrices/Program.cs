namespace _29.TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[,] numeros = new int[4, 4];
            int[] sumaColumnas = new int[numeros.GetLength(1)];

            //Recorrer la matriz para llenarla
            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición {i},{j}");
                    numeros[i, j] = int.Parse(Console.ReadLine());
                }

            }

            //Recorrer la matriz para mostrarla en pantalla

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.Write($"{numeros[i, j]} |");
                }
                Console.WriteLine();
            }

            //Recorrer la matriz para sumar sus los elementos de cada columna

            for (int i = 0; i < numeros.GetLength(1); i++)
            {
                for (int j = 0; j < numeros.GetLength(0); j++)
                {
                    sumaColumnas[i] += numeros[j, i];
                }
            }
            Console.WriteLine();

            //Recorrer el vector y mostrar la suma de cada columna

            for (int i = 0; i < sumaColumnas.Length; i++)
            {
                Console.Write($"{sumaColumnas[i]} |");
            }*/

            /*2. Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa 
             * caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la 
             * primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la 
             * matriz con el intercambio de filas.*/

            /*3. Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de 
             * 5x5 llena de números aleatorios. El algoritmo debe permitir:
             *  Usa la función Random para generar los números aleatorios. 
             *  Crea un arreglo adicional para almacenar la frecuencia de cada número. 
             *  Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número */

            int[,] numeros = new int[5, 5];
            int[] frecuencia = new int[10];
            Random random = new Random();

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición {i},{j}");
                    numeros[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    frecuencia[numeros[i, j] - 1]++;
                }
            }
            Console.WriteLine();

            for (int i = 0; i < frecuencia.Length; i++)
            {
                Console.WriteLine($"El número {i + 1} se repite {frecuencia[i]} veces");
            }
            Console.WriteLine();


        }
    }
}