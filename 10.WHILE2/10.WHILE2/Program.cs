namespace _10.WHILE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1*2*3*4*5)

            int contador = 1;
            int factorial = 1;

            while (contador <= 5)
            {
                factorial *= contador;
                contador++;
            }
            Console.WriteLine($"El factorial de {5} es: {factorial}");
        }
    }
}
