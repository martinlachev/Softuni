package com.company;

import java.util.Scanner;

/**
 * Created by MartinLachev on 4/4/2016.
 */
public class Problem2ParkingSystem {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String [] data = console.nextLine().split(" ");
        int matricRows = Integer.parseInt(data[0]);
        int matricColoms = Integer.parseInt(data[1]);
        String input = console.nextLine();
        boolean [][] matrix = new boolean[matricRows][matricColoms];
        while (!input.equals("stop")){
            input = console.nextLine();
            data = input.split(" ");
            int startRows =0;

        }
    }
}
