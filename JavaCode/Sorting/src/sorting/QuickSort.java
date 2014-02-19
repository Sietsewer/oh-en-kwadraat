/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package sorting;

/**
 *
 * @author Wessel
 */
public class QuickSort {

    private static void swap(int[] arr, int a, int b) {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

    private static void quickSort(int[] arr, int left, int right) {
        int lhold = left;
        int rhold = right;
        int pivot = (left + right) / 2; //deterministic pivot
        swap(arr, pivot, left);
        pivot = left;
        left++;

        while (right >= left) {
            if (arr[left] >= arr[pivot] && arr[right] < arr[pivot]) {
                swap(arr, left, right);
            } else if (arr[left] >= arr[pivot]) {
                right--;
            } else if (arr[right] < arr[pivot]) {
                left++;
            } else {
                right--;
                left++;
            }
        }

        swap(arr, pivot, right);
        pivot = right;
        if (pivot > lhold) {
            quickSort(arr, lhold, pivot);
        }
        if (rhold > pivot + 1) {
            quickSort(arr, pivot + 1, rhold);
        }
    }

    public static int[] sort(int[] arr) {
        quickSort(arr, 0, arr.length - 1);
        return arr;
    }
}
