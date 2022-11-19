using System;

namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cada sentencia o instruccion que termino en C# va con punto y coma
            //Creamos una variable para almacenar el string
            string message = string.Empty;
            //Pedimos al usuario que digite un texto cualquiera
            Console.WriteLine("Proporciona un mensaje por favor: ");
            //Guardamos el texto en la variable de tipo string
            message = Console.ReadLine();
            //Mostramos en pantalla el texto concatenado
            Console.WriteLine("Tu cadena es: " + message);
            Console.Read();
        }
    }
}