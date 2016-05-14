package com.company;

import java.util.*;

public class Problem7RandomizeNumbersFromNToM {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int a = console.nextInt();
        int b = console.nextInt();
        int c = 0;

        if (b<a){

            c = a;
            a = b;
            b = c;

        }

        ArrayList<Integer> elemnts= new ArrayList<>();
        for (int i = a; i <= b ; i++) {
            elemnts.add(i);


        }
        Collections.shuffle(elemnts);
        System.out.println(elemnts);

    }

}
