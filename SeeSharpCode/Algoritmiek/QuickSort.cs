using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public static class QuickSort
    {
        private static Chart chart;

        private static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
            chart.Series["Series1"].Points.DataBindY(new IEnumerable<int>[] { arr });
            chart.Update();
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

        public static int[] Sort(int[] arr, Chart _chart)
        {
            chart = _chart;
            Sort(arr, 0, arr.Length - 1);
            return arr;
        }
    }
}
