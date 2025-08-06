namespace _1.InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración e inicialización de variables
            string nombre = "Maria Fernanda";
            const string iva = "19%";
            string apellidos = "Vanegas Osorio";
            Console.Write("Bienvenidos al curso de Fundamentos de Programcación\n");
            nombre = "Maria Fernanda";
            //iva= "20%"; No puede cambiar el valor de 'iva' por ser una constante
            Console.Write("\t" + nombre + " " + apellidos + " " + iva);
            Console.ReadKey();


        }
    }
}
