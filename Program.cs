using System;
namespace acfour_Diego_Grajeda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdueix un número per establir el tamany de l'array: ");
            int arraySize = int.Parse(Console.ReadLine());

            int[] arrayNums = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Introdueix el nombre {i + 1}: ");
                arrayNums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Els nombres introduïts són:");
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine(arrayNums[i]);
            }
        }
    }
}
