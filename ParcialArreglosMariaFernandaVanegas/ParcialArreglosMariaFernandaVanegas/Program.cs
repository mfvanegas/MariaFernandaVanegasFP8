using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Numerics;
using System.Xml.Linq;

namespace ParcialArreglosMariaFernandaVanegas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Gestión y análisis de notas en una matriz
             * Se dispone de una tabla con las notas de 10 estudiantes en 4 materias: 
             * Matemáticas, Física, Inglés y Sociales.
             * Objetivo:
             * Desarrollar un programa que permita ingresar, procesar y mostrar información 
             * estadística basada en las notas, cumpliendo con los siguientes requisitos:
             * Especificaciones:
             * Ingreso de datos:
             * -Permitir al usuario ingresar por teclado las notas para cada estudiante 
             * y cada materia.
             * -Las notas deben ser valores numéricos decimales(float o double) entre 0 y 5.
             * -Validar que las notas ingresadas estén dentro del rango válido; 
             * en caso contrario, solicitar la nota nuevamente.
             * Almacenamiento:
             * Utilizar una matriz bidimensional de dimensiones 10 x 4, donde cada 
             * fila representa un estudiante y cada columna una materia(en el orden: 
             * Matemáticas, Física, Inglés, Sociales).
             * Mostrar matriz:
             * Al finalizar el ingreso, mostrar en pantalla la matriz completa de notas, 
             * con encabezados claros para estudiantes y materias, en un formato tabulado.
             * Cálculo de promedios:
             * Calcular y mostrar:
             * a) El promedio total de todas las notas de la matriz.
             * b) El promedio de las notas del estudiante número 9(fila índice 8).
             * c) El promedio de las notas para cada materia(columna), mostrando 
             * cada resultado con el nombre de la materia correspondiente.
             * Presentación de resultados:
             * Incluir mensajes claros que indiquen qué promedio se está mostrando.
             * Consideraciones adicionales:
             * Asegúrese de validar las entradas para evitar datos fuera de rango 
             * o formatos inválidos.*/

            int i, j;
            int estudiantes = 10;
            int materias = 4;
            double[,] notas = new double[estudiantes, materias];
            double sumaTotal = 0;

            // Ingreso de notas
            for (i = 0; i < estudiantes; i++)
            {
                Console.WriteLine($"\n Ingrese las notas del estudiante #{i + 1}");

                // Matemáticas
                double nota;
                do
                {
                    Console.Write("Ingrese la nota de Matemáticas (0 - 5): ");
                    nota = double.Parse(Console.ReadLine());
                    if (nota < 0 || nota > 5)
                        Console.WriteLine(" Nota inválida. Intente nuevamente.");
                } while (nota < 0 || nota > 5);
                notas[i, 0] = nota;
                sumaTotal += nota;

                // Física
                do
                {
                    Console.Write("Ingrese la nota de Física (0 - 5): ");
                    nota = double.Parse(Console.ReadLine());
                    if (nota < 0 || nota > 5)
                        Console.WriteLine(" Nota inválida. Intente nuevamente.");
                } while (nota < 0 || nota > 5);
                notas[i, 1] = nota;
                sumaTotal += nota;

                // Inglés
                do
                {
                    Console.Write("Ingrese la nota de Inglés (0 - 5): ");
                    nota = double.Parse(Console.ReadLine());
                    if (nota < 0 || nota > 5)
                        Console.WriteLine(" Nota inválida. Intente nuevamente.");
                } while (nota < 0 || nota > 5);
                notas[i, 2] = nota;
                sumaTotal += nota;

                // Sociales
                do
                {
                    Console.Write("Ingrese la nota de Sociales (0 - 5): ");
                    nota = double.Parse(Console.ReadLine());
                    if (nota < 0 || nota > 5)
                        Console.WriteLine(" Nota inválida. Intente nuevamente.");
                } while (nota < 0 || nota > 5);
                notas[i, 3] = nota;
                sumaTotal += nota;
            }

            // Mostrar la matriz
            Console.WriteLine("\n MATRIZ DE NOTAS");
            Console.WriteLine("Estudiante\tMatemáticas\tFísica\tInglés\tSociales");

            for (i = 0; i < estudiantes; i++)
            {
                Console.Write($"#{i + 1}\t\t");
                for (j = 0; j < materias; j++)
                {
                    Console.Write($"{notas[i, j]:0.0}\t\t");
                }
                Console.WriteLine();
            }

            // Promedio total
            double promedioTotal = sumaTotal / (estudiantes * materias);
            Console.WriteLine($"\nPromedio total de todas las notas: {promedioTotal:0.00}");

            // Promedio del estudiante #9 (índice 8)
            double sumaEstudiante9 = 0;
            for (j = 0; j < materias; j++)
            {
                sumaEstudiante9 += notas[8, j];
            }
            double promedioEst9 = sumaEstudiante9 / materias;
            Console.WriteLine($"Promedio del estudiante #9: {promedioEst9:0.00}");

            // Promedio por materia
            double sumaMatematicas = 0, sumaFisica = 0, sumaIngles = 0, sumaSociales = 0;
            for (i = 0; i < estudiantes; i++)
            {
                sumaMatematicas += notas[i, 0];
                sumaFisica += notas[i, 1];
                sumaIngles += notas[i, 2];
                sumaSociales += notas[i, 3];
            }

            double promedioMatematicas = sumaMatematicas / estudiantes;
            double promedioFisica = sumaFisica / estudiantes;
            double promedioIngles = sumaIngles / estudiantes;
            double promedioSociales = sumaSociales / estudiantes;

            Console.WriteLine("\nPromedio por materia:");
            Console.WriteLine($"Matemáticas: {promedioMatematicas:0.00}");
            Console.WriteLine($"Física: {promedioFisica:0.00}");
            Console.WriteLine($"Inglés: {promedioIngles:0.00}");
            Console.WriteLine($"Sociales: {promedioSociales:0.00}");

            Console.ReadKey();
        }



    }
}    

