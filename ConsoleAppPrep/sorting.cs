﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPrep
{
    public class sorting
    {
        public static void selectionsort(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[min]) min = j;
                }

                if (min != i) utility.swap(ref A, i, min);
            }
        }

        public static void insertionSort(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int j = i - 1;
                int k = A[i];

                while (j >= 0 && A[j] > k)
                {
                    A[j + 1] = A[j];
                    j--;
                }

                A[j + 1] = k;
            }
        }
        
        public static void bubbleSort(int[] A)
        {
            for (int i = A.Length-1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (A[j - 1] > A[j]) utility.swap(ref A, j - 1, j);
                }
            }
        }

        public static void quickSort(int[] A,int p,int q)
        {
            if (p < q)
            {
                int r = partition(A, p, q);
                quickSort(A, p, r - 1);
                quickSort(A, r + 1, q);
            }
        }
        public static int partition(int[] A,int p, int q)
        {
            int i = p - 1;
            int j = p;

            int k = A[q];

            while (j < q)
            {
                if (A[j] < k)
                {
                    utility.swap(ref A, i + 1, j);
                    i++;
                }
                j++;
            }

            A[q] = A[i + 1];
            A[i + 1] = k;
            return i + 1;
        }

        public static void mergeSort(int[] A, int p, int q)
        {
            if (p < q)
            {
                int mid = p + (q - p) / 2;
                mergeSort(A, p, mid);
                mergeSort(A, mid + 1, q);
                merge(A, p, mid, q);
            }
        }

        private static void merge(int[] A, int p,int mid, int q)
        {
            int l1 = mid - p + 1;
            int l2 = q - mid;

            int[] left = new int[l1];
            int[] right = new int[l2];

            for(int i1=0; i1 < left.Length ;i1++)
            {
                left[i1] = A[p + i1];
            }

            for (int j1 = 0; j1 < right.Length; j1++)
            {
                right[j1] = A[mid + 1 + j1];
            }

            int i = 0;
            int j = 0;
            int k = p;

            while(i<left.Length && j<right.Length)
            {
                if (left[i] < right[j])
                {
                    A[k] = left[i];
                    i++;
                }
                else
                {
                    A[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < left.Length)
            {
                
                A[k] = left[i];
                i++;
                
                k++;
            }

            while (i < left.Length && j < right.Length)
            {
                
                A[k] = right[j];
                j++;
                
                k++;
            }
        }

        //All numbers in array A will be in Range of 0 - 9
        // k = 10
        public static void countingSort(int[] A)
        {
            int[] C = new int[10];

            foreach (var item in A)
            {
                C[item]++;
            }

            for (int j = 1; j < C.Length; j++)
            {
                C[j] = C[j] + C[j - 1];
            }

            int[] B = new int[A.Length];
            Array.Copy(A, B, A.Length);

            for (int i = 0; i < B.Length; i++)
            {
                A[C[B[i]] - 1] = B[i];
                C[B[i]]--;
            }
        }
    }
}
