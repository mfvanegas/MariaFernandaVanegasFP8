namespace _23.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Unidimensionales
            //Vectores

            /*int[] numeros = new int[5]; //El vector numeros tiene 5 posiciones 
            string[] nombres = new string[4];

            //Asignar valores a las posiciones
            numeros[0] = 20;
            numeros[1] = 15;
            numeros[2] = 5;
            numeros[3] = 30;
            numeros[4] = 45;
            //numeros[5] = 85; Esto es un error porque el indice 5 no existe.

            int[] numeros1 = new int[] { 5, 12, 4, 7, 9, 21 }; //Otra forma de inicializar un vector
            int[] numeros2 = { 5, 12, 4, 7, 9 };
            //Yo puedo recorrer el vector para llenarlo de datos o para recuperar los datos. 
            //El mas optimo es for

            char[] caracter = new char[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ingrese el caracter para la posición {i + 1}, con índice {i}:");
                caracter[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine($"El vector caracter, en la posción 3, tiene almacenado el dato: {caracter[2]}");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"El vector caracter, en la posción {i + 1}, tiene almacenado el dato: {caracter[i]}");
            }

            for (int i = 0; i < caracter.Length; i++) //Otra forma de recorrer el vector, Length me devuelve la cantidad de posiciones del vector
            {
                Console.Write(caracter[i] + " | ");
            }*/

            //Vamos a hacer el ejercicio de los nombres 

            string[] nombres = new string[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ingrese el nombre para la posición {i + 1}, con índice {i}:");
                nombres[i] = Console.ReadLine();
            }

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write(nombres[i] + " | ");
            }
        }
    }     
}
