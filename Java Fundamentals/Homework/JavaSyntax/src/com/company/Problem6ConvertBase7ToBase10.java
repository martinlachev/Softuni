package com.company;

import java.util.Scanner;

/**
 * Created by MartinLachev on 3/21/2016.
 */
public class Problem6ConvertBase7ToBase10 {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        System.out.println("Base 7: ");
        String input = console.next();
        String reverse = new StringBuilder(input).reverse().toString();

        int sum = 0;

        int [] arr2 = new int[reverse.length()];

        for (int i = 0; i < arr2.length; i++) {

            arr2[i] = (Character.getNumericValue(reverse.charAt(i)));
            arr2[i] = (int)(arr2[i]* Math.pow(7,i));
            sum +=arr2[i];
        }
        System.out.print("Base 10: ");
        System.out.print(sum);

    }
}
