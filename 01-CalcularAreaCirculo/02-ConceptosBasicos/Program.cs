using System;

namespace CircleAreaCalculator {
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio: crear un programa que calcula el area de un circulo*/
            //Creamos nuestras constantes y variables
            const double PI = 3.1416;
            string userData;
            double radius;
            double circleArea;

            //Pedimos al usuario que ingrese los datos
            Console.WriteLine("Proporcione el radio del circulo: ");
            //Guardamos la respuesta en la variable correspondiente
            userData = Console.ReadLine();
            //En que caso de que el usuario nos de un dato incorrecto haremos una validacion
            if (double.TryParse(userData, out radius))
            {
                //En caso de que el numero sea correcto ejecutaremos la formula y mostraremos el resultado
                circleArea = PI * Math.Pow(radius, 2);
                Console.WriteLine($"El area de tu circulo es: {circleArea}");
            }
            else {
                //En caso de que el dato sea incorrecto mostraremos este mensaje
                Console.WriteLine("El dato es incorrecto");
            }
            Console.ReadLine();
        }
    }

}