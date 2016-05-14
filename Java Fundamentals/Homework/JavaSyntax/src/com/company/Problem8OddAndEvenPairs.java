package com.company;

import java.util.ArrayList;
import java.util.Scanner;

/**
 * Created by MartinLachev on 3/23/2016.
 */
public class Problem8OddAndEvenPairs {
    public static void main(String[] args) {
        Scanner console = new Scanner (System.in);
        int sumarr = 0;
        String  [] arr = console.nextLine().split(" ");

        int [] intarr = new int[arr.length];
        if (arr.length%2!=0){
            System.out.println("Invalid length");
        }

        for (int i = 0; i < intarr.length; i++) {
            intarr[i]=Integer.parseInt(arr[i]);

        }
        for (int i = 0; i < intarr.length; i+=2) {
            if (intarr[i]%2==0 && intarr[i+1]%2==0){
                System.out.println(intarr[i]+","+intarr[i+1] + "-> both are even");
            }
            if (intarr[i]%2!=0 && intarr[i+1]%2!=0){
                System.out.println(intarr[i]+","+intarr[i+1] + "-> both are odd");
            }
            else{
                System.out.println(intarr[i]+","+intarr[i+1] + "-> different");
            }

        }
    }
}
