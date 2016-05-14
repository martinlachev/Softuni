package com.company;

import java.util.Scanner;

/**
 * Created by User on 10.3.2016 г..
 */
public class SumNumbersFrom1toN {
    public static void main(String[] args){
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());
        int sum = 0;
        for (int i = 0; i <=n; i++) {
            sum+=i;

        }
        System.out.println(sum);

    }
}
