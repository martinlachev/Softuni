package com.company;

import com.sun.deploy.util.StringUtils;

import java.util.Scanner;


public class PrintACharecterTriangle {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        System.out.print("n = ");
        int number = Integer.parseInt(console.nextLine());
        for (int i = 0; i <= number  ; i++) {
            for (char j = 97; j < 97+(i) ; j++) {
                System.out.print(j + " ");

            }
            System.out.println();

        }
        for (int i = number-1; i > 0; i--) {
            for (char j = 0; j < i ; j++) {

                System.out.print((char)(j + 97) + " ");
            }
            System.out.println();

        }
    }
}
