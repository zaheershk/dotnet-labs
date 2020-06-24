using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ds_algo
{
    public static class Sort
    {
        public static void BubbleSort(int length, int[] array)
        {
            for (int i = 0; i < length; i++)
            {
                int temp;
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }

                    Console.WriteLine($"Temp sub-array: [{string.Join(", ", array)}]");
                }

                Console.WriteLine($"Temp array: [{string.Join(", ", array)}]");
            }

            Console.WriteLine($"Bubble sorted array: [{string.Join(", ", array)}]");
        }

        public static void SelectionSort(int length, int[] array)
        {
            for (int i = 0; i < length; i++)
            {
                int temp, minKey = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[j] < array[minKey])
                    {
                        minKey = j;
                    }
                }

                temp = array[minKey];
                array[minKey] = array[i];
                array[i] = temp;

                Console.WriteLine($"Temp array: [{string.Join(", ", array)}]");
            }

            Console.WriteLine($"Selection sorted array: [{string.Join(", ", array)}]");
        }

        public static void InsertionSort(int length, int[] array)
        {
            for (int i = 1; i < length; i++)
            {
                int temp, j = i;
                while (j > 0 && array[j - 1] > array[j])
                {
                    temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    j--;

                    Console.WriteLine($"Temp sub-array: [{string.Join(", ", array)}]");
                }

                Console.WriteLine($"Temp array: [{string.Join(", ", array)}]");
            }

            Console.WriteLine($"Selection sorted array: [{string.Join(", ", array)}]");
        }

        public static void MergeSort(int length, int[] array)
        {
            MergeSortRecursive(array, 0, length - 1);
        }

        private static void MergeSortRecursive(int[] array, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (left + right) / 2;                

                MergeSortRecursive(array, left, mid);
                MergeSortRecursive(array, mid + 1, right);

                Merge(array, left, mid + 1, right);

                Console.WriteLine($"Temp array: [{string.Join(", ", array)}]");
            }
        }

        private static void Merge(int[] array, int left, int mid, int right)
        {
            int[] temp = new int[5];
            int i, leftEnd, numOfElements, tmpPos;

            leftEnd = mid - 1;
            tmpPos = left;
            numOfElements = right - left + 1;

            while ((left <= leftEnd) && (mid <= right))
            {
                if (array[left] <= array[mid])
                    temp[tmpPos++] = array[left++];
                else
                    temp[tmpPos++] = array[mid++];
            }

            while (left <= leftEnd)
                temp[tmpPos++] = array[left++];

            while (mid <= right)
                temp[tmpPos++] = array[mid++];

            for (i = 0; i < numOfElements; i++)
            {
                array[right] = temp[right];
                right--;
            }

            Console.WriteLine($"Temp sub-array: [{string.Join(", ", temp)}]");
        }
    }
}
