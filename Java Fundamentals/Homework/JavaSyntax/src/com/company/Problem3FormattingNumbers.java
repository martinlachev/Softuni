package com.company;

import java.util.Scanner;

/**
 * Created by MartinLachev on 3/17/2016.
 */
public class Problem3FormattingNumbers {
    public static void main(String[] args) {

        Scanner console = new Scanner(System.in);
        int a = console.nextInt();
        float b = console.nextFloat();
        float c = console.nextFloat();

        System.out.printf("|"+Integer.toHexString(a)+"       "+ "|"+
                Integer.toBinaryString(a)+"|" + "      "  +  "%.2f" + "|" + "%.3f",b,c);








    }
}
