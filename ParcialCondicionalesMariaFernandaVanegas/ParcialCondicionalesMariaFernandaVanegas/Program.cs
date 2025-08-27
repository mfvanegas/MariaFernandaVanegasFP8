namespace ParcialCondicionalesMariaFernandaVanegas
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*Desarrollar un programa en C# que permita determinar el elemento zodiacal de una persona, en función de su mes de nacimiento y signo zodiacal (70%).
           El programa debe:
           Solicitar al usuario que ingrese el mes de nacimiento (por ejemplo: "marzo").
           Solicitar el signo zodiacal de la persona (por ejemplo: "aries").
           Analizar la información ingresada y determinar a qué elemento pertenece la persona, según las siguientes condiciones:
           Elemento: Fuego
           Mostrar el mensaje “El elemento de la persona es Fuego” si:
           El mes de nacimiento es: marzo, abril, julio, agosto, noviembre o diciembre,Y
           El signo zodiacal es: Aries, Leo o Sagitario.
           Elemento: Tierra
           Mostrar el mensaje “El elemento de la persona es Tierra” si:
           El mes de nacimiento es: abril, mayo, agosto, septiembre, diciembre o enero,Y
           El signo zodiacal es: Tauro, Virgo o Capricornio.
           Elemento: Aire
           Mostrar el mensaje “El elemento de la persona es Aire” si:
           El mes de nacimiento es: mayo, junio, septiembre, octubre, enero o febrero,Y
           El signo zodiacal es: Géminis, Libra o Acuario.
           Elemento: Agua
           Mostrar el mensaje “El elemento de la persona es Agua” si:
           El mes de nacimiento es: marzo, junio, julio, octubre, noviembre, febrero,Y
           El signo zodiacal es: Cáncer, Escorpión o Piscis.
           Nota importante:
           En caso de que no se cumpla ninguna condición, no se debe mostrar ningún mensaje o se puede indicar que los datos no coinciden con ninguna categoría.*/
           
            char signo = ' ';
            char elementos = ' ';
            char meses = ' ';

            Console.WriteLine("Ingrese el mes de naciiento: E:enero, F:febrero, M:marzo, A:abril, X:mayo, J:junio, Z:julio, T:agosto, S:septiembre, O:octubre, N:noviembre, D:diciembre");
            meses = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Ingrese el signo del zodiaco: A:aries, L:leo, S:sagitario, T:tauro, V:virgo, C:capricornio, G:geminis, LI:libra, R:acuario, N:cancer, E:escorpion, P:piscis");
            signo = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de elementos: Fuego, Tierra, Aire, Agua");
            elementos = Convert.ToChar(Console.ReadLine());

            if (meses == ' ')   
            {
                Console.WriteLine("Ingrese 'M' 'A' 'Z' 'T' 'N o 'D'");
            }
            else if (signo == ' ')
            {
                Console.WriteLine("Ingrese 'A' 'L' o 'S'");
            }
            else if (elementos == ' ')
            {
                Console.WriteLine("El elemento de la persona es Fuego");
            }
            else
            {
                Console.WriteLine("Los datos no coinciden con ninguna categoría");
            }

        }

    }
}
