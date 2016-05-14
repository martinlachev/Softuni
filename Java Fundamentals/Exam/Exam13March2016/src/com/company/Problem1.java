package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class Problem1 {

    public static void main(String[] args) {
        Scanner console = new Scanner (System.in);
        String[] arr = console.nextLine().split(", ");


        String temp = "";
        String temp1 = "";

        List<String> list = new ArrayList<>();
        for (int i = 0; i < arr.length; i++) {
            for (int j = 0; j < arr[i].length(); j++) {

                switch (arr[i].charAt(j)){
                    case '0':temp = temp + "zero" + "-";break;
                    case '1':temp1 = temp1 + "one" + "-";break;
                    case '2':
                }

            }


        }
        list.add(temp);
        list.add(temp1);

        for (String s : list) {
            System.out.println(s);
        }


    }
    public  static void StringSwitcher(String [] arr){

    }
}
