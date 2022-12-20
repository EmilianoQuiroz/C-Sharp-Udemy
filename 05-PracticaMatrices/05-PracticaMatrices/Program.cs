using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion del primer array
            Console.ForegroundColor = ConsoleColor.Red;/*Asignamos un color a nuestro array*/
            int[] array1= new int[3];
            array1[0] = 100;
            array1[1] = 200;
            Console.WriteLine($"array1[0] = {array1[0]} y array1[1] = {array1[1]}");
            Console.ReadKey();

            //Declaracion del segundo array
            Console.ForegroundColor = ConsoleColor.Green;/*Asignamos un color a nuestro array*/
            int[] array2 = { 1, 2, 3, 4, 5, 6};
            string[] array3 = { "Lun", "Mar", "Mier", "Jue", "Vie"};
            Console.WriteLine($"array2[2] = {array2[2]}, array2[3] = {array2[3]} y array3[1] = {array3[1]}");
            Console.ReadKey();

            //Recorrer un Array con un foreach
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (int item in array1)
            { 
            Console.WriteLine(item);
            }
            Console.ReadKey();

            int[][] arrayOfArrays = new int[2][];
            arrayOfArrays[0] = new int[] { 1 };
            arrayOfArrays[1] = new int[] {2, 3, 4, 5};
            //Recorremos nuestro array de arrays
            foreach (int[] item in arrayOfArrays)
            {
                foreach (int subItem in item)
                {
                    Console.WriteLine(subItem);
                }
            }
            Console.ReadKey();

            //Numero de dimenciones de nuestro array
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"array1 tiene {array1.Length} elementos");
            Console.WriteLine($"array2 tiene {array2.Length} elementos");
            Console.WriteLine($"array3 tiene {array3.Length} elementos");
            Console.WriteLine($"arrayOfArrays tiene {arrayOfArrays.Length} elementos");
            Console.ReadKey();

            //Arreglos de dos dimenciones
            int[,] studentScores = new int[2, 2];
            studentScores[0, 0] = 10;
            studentScores[0, 1] = 9;
            studentScores[1, 0] = 8;
            studentScores[1, 1] = 10;

            Console.WriteLine($"El estudiante 1 del grupo 1 tiene una nota de {studentScores[0,0]}");
            Console.WriteLine($"El estudiante 1 del grupo 1 tiene una nota de {studentScores[1, 0]}");
            //Numero de dimenciones de nuestro array
            Console.WriteLine($"studentScore tiene {studentScores.Rank} dimenciones");
            Console.ReadKey();
        }
    }
}