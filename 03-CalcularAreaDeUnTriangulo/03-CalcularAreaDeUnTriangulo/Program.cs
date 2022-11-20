using System;

namespace HomeworkSection3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userData;
            string userData2;
            double baseDelTriangulo;
            double alturaDelTriangulo;
            double areaDelTriangulo;
            Console.WriteLine("Hola, te proporcionaré el área de un cuadrado.");
            Console.WriteLine(@"    /\");
            Console.WriteLine(@"   /  \");
            Console.WriteLine(@"  /    \");
            Console.WriteLine(@" /      \");
            Console.WriteLine(@"/________\");
            //Pedimos al usuario el valor de la base del triangulo
            Console.WriteLine("¿Cuánto mide la base del triangulo?");
            //Guardo el dato en la variable userdata
            userData = Console.ReadLine();

            //Si el dato es correcto lo parseo lo guardo en la variable base del triangulo y paso a la siguiente condicion
            if (double.TryParse(userData, out baseDelTriangulo))
            {
                //Pido al usuario el valor del alto del triangulo
                Console.WriteLine("Cuanto mide de alto el triangulo?");
                //Guardo el dato en la variable userdata2 
                userData2 = Console.ReadLine();

                //Si el valor es correcto lo parseammos y lo guardamos en la variable alturadeltriangulo
                if (double.TryParse(userData, out alturaDelTriangulo))
                {
                    //Hacemos el calculo y lo guardamos en la variable areadeltriangulo
                    areaDelTriangulo = (baseDelTriangulo * alturaDelTriangulo) * 2;
                    //Mostramos el resultado en pantalla
                    Console.WriteLine($"El area de tu triangulo es { areaDelTriangulo }");
                }
                else 
                {
                    Console.WriteLine("Los datos proporcionados son incorrectos.");
                }
            }
            else
            {
                //En caso de que cualquiera de los dos valores sea erroneo se mostrara el siguiente mensaje
                Console.WriteLine("Los datos proporcionados son incorrectos.");
            }
            Console.ReadKey();
        }
    }
}