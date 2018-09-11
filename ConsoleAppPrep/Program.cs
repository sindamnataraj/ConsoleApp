using System;

namespace ConsoleAppPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 9, 8, 2,7, 6, 5, 4, 2 };

            sorting.countingSort(A);

            utility.printArray(A);

            Console.ReadLine();
        }
    }
}
