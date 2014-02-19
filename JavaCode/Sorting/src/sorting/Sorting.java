/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package sorting;

import java.util.Random;

/**
 *
 * @author Wessel
 */
public class Sorting {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int size = 100;
        int data[] = new int[size];
        Random r = new Random();
        
        for (int i = 0; i < data.length; i++){
            data[i] = r.nextInt(size);
        }
        
        int[] res1 = QuickSort.sort(data.clone());
        int[] res2 = QuickSort.sort(data.clone());
        for (int i = 0; i < res1.length; i++){
            System.out.println(res1[i]);
        }
    }
}
