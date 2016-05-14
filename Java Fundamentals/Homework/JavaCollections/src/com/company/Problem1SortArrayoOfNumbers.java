package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class Problem1SortArrayoOfNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Please enter size of the array: ");
        int n = scanner.nextInt();
        int[] arr = new int[n];
        System.out.print("Please enter your array here: ");
        for (int i = 0; i < arr.length; i++) {
            arr[i] = scanner.nextInt();
        }
        System.out.print("Before sort: ");
        for (int i : arr) {
            System.out.print(i + " ");
        }
        Arrays.sort(arr);
        System.out.println();
        System.out.print("After sort: ");
        for (int i : arr) {

            System.out.print(i+" ");
        }
    }
}
