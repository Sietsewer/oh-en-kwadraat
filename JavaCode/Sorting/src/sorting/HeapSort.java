/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package sorting;

/**
 *
 * @author Wessel
 */
public class HeapSort {

    private static void heapSort(int[] arr) {
        int n = arr.length;
        int i = n / 2;
        int parent, child, t;

        while (true) {
            if (i > 0) {
                i--;
                t = arr[i];
            } else {
                n--;
                if (n == 0) {
                    return;
                }
                t = arr[n];
                arr[n] = arr[0];
            }

            parent = i;
            child = (i * 2) + 1;

            while (child < n) {
                if (child + 1 < n && arr[child + 1] > arr[child]) {
                    child++;
                }
                if (arr[child] > t) {
                    arr[parent] = arr[child];
                    parent = child;
                    child = (parent * 2) + 1;
                } else {
                    break;
                }
            }
            arr[parent] = t;
        }
    }

    public static int[] sort(int[] arr) {
        heapSort(arr);
        return arr;
    }
}
