namespace _11.While3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados.*/

            int numero;
            int suma = 0;

            Console.WriteLine("Ingrese números enteros positivos");
            Console.WriteLine("Ingrese un número entero negativo para terminar");

            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                suma += numero;
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"La suma total de los numeros ingresados es: {suma}");
        }
    }
}
