package com.company;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

/**
 * Created by MartinLachev on 3/30/2016.
 */
public class Problem4LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String [] sarr = console.nextLine().split(" ");
        List<String> list = new ArrayList<String>();
        String inpt = "";
        int largest =1,index =0, temp =1;
        for (int i = 1; i < sarr.length; i++) {
           if (Integer.parseInt(sarr[i]) > Integer.parseInt(sarr[i-1]) ) {
               inpt = inpt + sarr[i - 1];


           }
           list.add(inpt);




        }
        for (String s : list) {
            System.out.println(s);
        }










    }
}


