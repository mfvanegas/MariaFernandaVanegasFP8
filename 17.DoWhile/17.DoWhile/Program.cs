namespace _17.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Algoritmo que genere y calcle la suma d elos 5 primeros números enteros positivos  

            int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador += contador;
            } while (contador < 5);

            Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");*/

            /*17. Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. 
             * Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar.*/

            int número = 0;
            int contador = 1;
            string respuesta = " ";

            do
            {
                Console.WriteLine("Por favor ingrese un número)");
                número = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{número} x {contador} = {número * contador}");
                    contador++;

                } while (contador <= 10);

                contador = 1;
                Console.WriteLine("Quiere generar otra tabla de multiplicar: s: sí - n: no");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");
        }
    }
}
