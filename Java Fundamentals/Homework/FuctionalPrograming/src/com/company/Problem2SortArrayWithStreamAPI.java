package com.company;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

/**
 * Created by MartinLachev on 4/3/2016.
 */
public class Problem2SortArrayWithStreamAPI {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String [] sarr = console.nextLine().split(" ");
        String ass = console.nextLine();
        Integer [] arr = new Integer [sarr.length];
        for (int i = 0; i < sarr.length; i++) {
            arr[i] = Integer.parseInt(sarr[i]);
        }
        List<Integer> list = Arrays.asList(arr);
        if (ass.equals("Ascending")){

            list
                    .stream()
                    .sorted((e1,e2) -> Integer .compare(e1,e2))
                    .forEach(integer -> System.out.print(integer +" "));
        }else if (ass.equals("Desceding")) {
            list
                    .stream()
                    .sorted((e1,e2) -> Integer .compare(e2,e1))
                    .forEach(integer -> System.out.print(integer +" "));
        }



    }
}
