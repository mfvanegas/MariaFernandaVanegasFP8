using System.Security.Cryptography.X509Certificates;

namespace ParcialCiclosMariaFernandaVanegas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se requiere diseñar un programa para procesar las notas definitivas de Física de un grupo de 15 estudiantes. Las calificaciones están en un rango de 0.0 a 5.0.
             * El programa debe realizar las siguientes tareas:
             * Ingresar por teclado la nota final de cada estudiante.
             * Calcular el promedio general del grupo.
             * Excelente: nota ≥ 4.8
             * Bueno: 4.0 ≤ nota ≤ 4.7
             * Regular: 3.0 ≤ nota ≤ 3.9
             * Descuidado: nota ≤ 2.9
             * Contar y mostrar por pantalla el número total de estudiantes en cada categoría.
             * Mostrar en pantalla el promedio del grupo y la cantidad de alumnos clasificados en cada nivel.*/

            float notas = 0;
            float sumanotas = 0;
            int totalestudiantes = 15;

            int Excelente = 0;
            int Bueno = 0;
            int Regular = 0;
            int Descuidado = 0;

            Console.WriteLine("Ingrese las notas finales de los 15 estudiantes (rnago 0.0 a 5.0):");

            for (int i = 1; i <= totalestudiantes; i++)
            {
                Console.Write($"Nota del estudiante {i}: ");
                float nota = float.Parse(Console.ReadLine());

                sumanotas += notas;

                if (notas >= 4.8f)
                {
                    Excelente++;
                }
                else if (notas <= 4.0f && notas <= 4.7f)
                {
                    Bueno++;
                }
                else if (notas <= 3.0f && notas <= 3.9f)
                {
                    Regular++;
                }
                else if(notas <= 2.9f)
                {
                    Descuidado++;
                }
            }

            float promedio = sumanotas / totalestudiantes;
            Console.WriteLine("\n Resultados");
            Console.WriteLine($"Promedio general del grupo: {promedio:F2}");
            Console.WriteLine($"Estudiantes en categoría Excelente (nota ≥ 4.8): {Excelente}");
            Console.WriteLine($"Estudiantes en categoría Bueno (4.0 ≤ nota ≤ 4.7): {Bueno}");
            Console.WriteLine($"Estudiantes en categoría Regular (3.0 ≤ nota ≤ 3.9): {Regular}");
            Console.WriteLine($"Estudiantes en categoría Descuidado (nota ≤ 2.9): {Descuidado}");
        }
    }
}
