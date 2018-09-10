using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPrep
{
    public class utility
    {
        public static void swap(ref int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

        public static void printArray(int[] A)
        {
            foreach (var item in A)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
        }
    }
}
