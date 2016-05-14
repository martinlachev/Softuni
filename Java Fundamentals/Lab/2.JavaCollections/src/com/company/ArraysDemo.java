package com.company;

import java.lang.reflect.Array;
import java.util.Arrays;

public class ArraysDemo {

    public static void main(String[] args) {
	    int[] fib = new int [21];

        fib[1] = 1;
        fib[2] = 1;
        //... zada spestim wreme prawim for
        for (int i = 3; i < fib.length; i++) {
            fib[i]= fib [i-1] + fib[i-2];

        }
        for (int element: fib) {
            System.out.println(element);
        }

        int [] unsorted = new int [5];

        unsorted [0] =4;
        unsorted [1] =3;
        unsorted [2] =12;
        unsorted [3] =34;
        unsorted [4] = 123;

        Arrays.sort(unsorted);

        for (int i : unsorted) {
            System.out.println(i);
        }
        doSomthing(unsorted);
        for (int i : unsorted) {
            System.out.println(i);
        }



    }
    static void doSomthing(int [] arr){
        arr[3] = 1500;
    }
}
