package com.company;

import java.util.Scanner;


public class Problem2SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String [] arr = console.nextLine().split(" ");

        for (int i = 0; i < arr.length; i++) {

            if (i == arr.length-1){
                System.out.println(arr[arr.length-1]);
                break;
            }

            if (arr[i].equals(arr[i+1])) {
                System.out.print(arr[i] + " "  );

            }
            else System.out.println(arr[i]);



        }


    }
}
