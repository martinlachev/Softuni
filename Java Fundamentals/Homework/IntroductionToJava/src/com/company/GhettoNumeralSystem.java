package com.company;

import com.sun.deploy.util.StringUtils;

import java.util.Scanner;

/**
 * Created by User on 10.3.2016 г..
 */
public class GhettoNumeralSystem {
    public static void main(String []args){
        Scanner console = new Scanner(System.in);
        System.out.print("Decimal: ");
        String [] hoi = console.next().split("");

        for (int i = 0; i < hoi.length; i++) {

            switch (hoi[i]){
                case "0" :hoi[i]="Gee";break;
                case "1" :hoi[i]="Bro";break;
                case "2" :hoi[i]="Zuz";break;
                case "3" :hoi[i]="Ma";break;
                case "4" :hoi[i]="Duh";break;
                case "5" :hoi[i]="Yo";break;
                case "6" :hoi[i]="Dis";break;
                case "7" :hoi[i]="Hood";break;
                case "8" :hoi[i]="Jam";break;
                case "9" :hoi[i]="Mack";break;

            }

        }
        System.out.print("Ghetto: " );
        for (int i = 0; i <hoi.length; i++) {
            System.out.print(hoi[i]);

        }
    }
}
