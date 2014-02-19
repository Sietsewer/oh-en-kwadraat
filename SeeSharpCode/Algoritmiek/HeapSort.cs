using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public static class HeapSort
    {
        private static Chart chart;
        private static void heapSort(int[] arr)
        {
            int n = arr.Length;
            int i = n / 2;
            int parent, child, t;

            while (true)
            {
                if (i > 0)
                {
                    i--;
                    t = arr[i];
                }
                else
                {
                    n--;
                    if (n == 0)
                        return;
                    t = arr[n];
                    arr[n] = arr[0];
                    chart.Series["Series1"].Points.DataBindY(new IEnumerable<int>[] { arr });
                    chart.Update();
                }

                parent = i;
                child = (i * 2) + 1;

                while (child < n)
                {
                    if (child + 1 < n && arr[child + 1] > arr[child])
                        child++;
                    if (arr[child] > t)
                    {
                        arr[parent] = arr[child];
                        parent = child;
                        child = (parent * 2) + 1;
                    }
                    else
                        break;
                }
                arr[parent] = t;
                chart.Series["Series1"].Points.DataBindY(new IEnumerable<int>[] { arr });
                chart.Update();

            }
        }

        public static int[] Sort(int[] arr, Chart _chart)
        {
            chart = _chart;
            heapSort(arr);
            return arr;
        }
    }
}
