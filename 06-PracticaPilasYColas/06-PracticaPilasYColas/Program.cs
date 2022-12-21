using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            //PILAS
            string word;
            int counter;
            Stack greetingStack;

            //Usamos PUSH y POP
            Console.ForegroundColor = ConsoleColor.Green;
            greetingStack = new Stack();
            //Agregamos los valores a la pila
            greetingStack.Push("Hola");
            greetingStack.Push(" Buenos");
            greetingStack.Push(" Dias");

            counter = greetingStack.Count;
            Console.WriteLine($"Hay {counter} elementos en la pila.");//Muestra cuantos elementos hay en la pila
            for(int i = 0; i < counter; i++)
            { 
                word = (string)greetingStack.Pop();
                /*El metodo POP extrae el contenido de la pila*/
                Console.WriteLine($"Pop: {word}");
                Console.ReadKey();
            }

            //PEEK muestra que valor hay en la pila sin extraerlo
            Console.ForegroundColor = ConsoleColor.Blue;
            greetingStack = new Stack();
            //Agregamos los valores a la pila
            greetingStack.Push("Hola");
            greetingStack.Push(" Buenos");
            greetingStack.Push(" Dias");

            counter = greetingStack.Count;
            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingStack.Peek();
                /*El metodo POP extrae el contenido de la pila*/
                Console.WriteLine($"La siguiente palabra en la pila es: {word}");

                word = (string)greetingStack.Pop();
                Console.WriteLine($"Pop: {word}");
            }
            Console.ReadKey();

            //Clear
            //Clear sirve para limpiar datos de nuestra pila
            Console.ForegroundColor = ConsoleColor.Red;
            greetingStack = new Stack();
            greetingStack.Push("Hola");
            greetingStack.Push("Buenos");
            greetingStack.Push("Dias");

            if (greetingStack.Contains("Dias"))
            {
                greetingStack.Clear();
            }
            Console.WriteLine($"La pila greetingStack contiene {greetingStack.Count} elementos ");
            Console.ReadKey();

            //COLAS
            Console.ForegroundColor= ConsoleColor.Cyan;
            Queue greetingQueue = new Queue();
            greetingQueue.Enqueue("Hola");
            greetingQueue.Enqueue("buenos");
            greetingQueue.Enqueue("dias");

            counter = greetingQueue.Count;
            Console.WriteLine($"Hay {greetingQueue.Count} elementos en la cola");
            Console.ReadKey();

            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingQueue.Peek();
                Console.WriteLine($"El siguiente elemento en la cola es {word}");

                word = (string)greetingQueue.Dequeue();
                Console.WriteLine($"DEQUEUE: {word}");
            }
            Console.WriteLine($"Hay {greetingQueue.Count} elementos en la cola");
            Console.ReadKey();
        }
    }
}