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
                int num;
                do
                {
                    Console.Write($"Introdueix el nombre {i + 1} (ha de ser més gran que 0 o igual): ");
                    num = int.Parse(Console.ReadLine());

                    if (num < 0)
                    {
                        Console.WriteLine("El número introduït no és vàlid.");
                    }
                } while (num < 0);

                arrayNums[i] = num;
            }

            Console.WriteLine("Els nombres introduïts són:");
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine(arrayNums[i]);
            }

            for (int i = 0; i < arrayNums.Length - 1; i++)
            {
                for (int j = 0; j < arrayNums.Length - 1 - i; j++)
                {
                    if (arrayNums[j] < arrayNums[j + 1])
                    {
                        int aux = arrayNums[j];

                        arrayNums[j] = arrayNums[j + 1];

                        arrayNums[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("Els nombres ordenats en ordre descendent són:");
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine(arrayNums[i]);
            }
        }
    }
}
