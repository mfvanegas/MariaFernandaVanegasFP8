namespace _16.While8.Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*16. Escribe un algoritmo en el que el ordenador elija un número aleatorio entre 1 y 100. El usuario debe adivinar el número, 
             * y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. Usa un ciclo while para seguir pidiendo 
             * intentos hasta que el usuario adivine el número. */

            Random aleatorio = new Random();
            int numerosecreto = aleatorio.Next(1, 100);
            int intento = 0;

            Console.WriteLine("Adivina un numero enyre 1 y 100");

            while (intento != numerosecreto)
            {
                Console.WriteLine("Ingresa tu intento: ");
                intento = Convert.ToInt32(Console.ReadLine());

                if (intento < numerosecreto)
                {
                    Console.WriteLine("Muy bajo. Intenta otra vez. \n");

                }
                else if (intento > numerosecreto)
                {
                    Console.WriteLine("Muy alto. Intenta otra vez. \n");
                }
                else
                {
                    Console.WriteLine($"¡Correcto! El número era {numerosecreto}");
                }
            }
        }
    }
}
