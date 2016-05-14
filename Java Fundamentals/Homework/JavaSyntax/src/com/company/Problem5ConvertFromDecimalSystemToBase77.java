package com.company;

import java.util.Scanner;

/**
 * Created by MartinLachev on 3/18/2016.
 */
public class Problem5ConvertFromDecimalSystemToBase77 {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        System.out.print("Base 10:");
        String n = console.next();
        int input = Integer.parseInt(n);
        int [] arr = new int[n.length()];

        int remainder;
        int counter =0;


       do {

           remainder = input%7;
           input/=7;
           arr[counter] = remainder;
           counter++;


       }
       while (input != 0 );
        System.out.print("Base 7:");
        for (int i = arr.length-1; i >=0; i--) {

            System.out.print( arr[i]);

        }



    }
}
