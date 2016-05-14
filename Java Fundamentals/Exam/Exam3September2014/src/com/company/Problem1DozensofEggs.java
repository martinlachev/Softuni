package com.company;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class Problem1DozensofEggs {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        int dozen = 0;
        int eggs = 0 ;
        String temp = "";
        String temp2 = "";
        String [] arr =  new String[7];


        for (int i = 0; i < 7; i++) {
            arr[i]  = console.nextLine();


        }
        for (int i = 0; i < arr.length; i++) {
            temp2 = arr[i].replaceAll("\\s","");
            temp = temp2.replaceAll("[a-z]","");

            int count = Integer.parseInt(temp);

            arr[i]=arr[i].replaceAll("\\d+\\s+","");

            if (arr[i].equals("eggs")){
                eggs = eggs +count;
                count = 0;
            }
            else if (arr[i].equals("dozens")){
                dozen = dozen+count;
                count = 0;
           }


        }

        if (eggs >= 11){
            int result = eggs/12;
            dozen+=result;
            eggs = eggs - (result*12);
            System.out.printf("%d dozens + %d eggs",dozen,eggs);

        }





    }
}
