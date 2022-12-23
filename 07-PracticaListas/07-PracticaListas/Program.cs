using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Creando instancias de una lista
            Console.ForegroundColor = ConsoleColor.Red;
            List<int> list1 = new List<int>();
            list1.Add(10);
            list1.Add(20);
            list1.Add(30);
            list1.Add(40);
            list1.Add(50);
            list1.Add(60);
            list1.Add(70);
            ShowListContain(list1);
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Green;
            if (list1.Contains(50))
            {
                list1.Remove(50);
                Console.WriteLine("Se removio el 50");
            }
            ShowListContain(list1);
            Console.ReadKey();

            //Creacion de una lista en una sola linea de codigo 
            Console.ForegroundColor = ConsoleColor.Blue;
            List<int> list2 = new List<int>() { 80, 90, 100, 110};
            ShowListContain(list2);
            Console.ReadKey();

            //Para concatenar dos listas podemos usar la siguiente funcion
            Console.ForegroundColor = ConsoleColor.Cyan;
            list2.InsertRange(0, list1);/*En la posicion 0 de nuestra list2 incertaremos nuestra list1*/
            ShowListContain(list2);/*Ahora mostramos la list2 ya modificada*/
            Console.ReadKey();
        }

        private static void ShowListContain(List<int> list)
        {
            foreach (var item in list)
            { 
                Console.WriteLine(item);
            }
        }
    }
}