using System;

namespace ConsoleAppPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 9, 8, 7, 6, 5, 4, 2 };

            sorting.quickSort(A,0,A.Length-1);

            utility.printArray(A);

            Console.ReadLine();
        }
    }
}
