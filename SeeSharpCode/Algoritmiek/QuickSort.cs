using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    public static class QuickSort
    {
        private static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        private static void Sort(int[] arr, int left, int right)
        {
            int lhold = left;
            int rhold = right;
            int pivot = (left + right) / 2; //deterministic pivot
            Swap(arr, pivot, left);
            pivot = left;
            left++;

            while (right >= left)
            {
                if (arr[left] >= arr[pivot] && arr[right] < arr[pivot])
                    Swap(arr, left, right);
                else if (arr[left] >= arr[pivot])
                    right--;
                else if (arr[right] < arr[pivot])
                    left++;
                else
                {
                    right--;
                    left++;
                }
            }

            Swap(arr, pivot, right);
            pivot = right;
            if (pivot > lhold)
                Sort(arr, lhold, pivot);
            if (rhold > pivot + 1)
                Sort(arr, pivot + 1, rhold);
        }

        public static int[] Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
            return arr;
        }
    }
}
