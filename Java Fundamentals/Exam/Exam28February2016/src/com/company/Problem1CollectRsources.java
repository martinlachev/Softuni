package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Problem1CollectRsources {

    public static void main(String[] args) {
	    Scanner console = new Scanner(System.in);
        String [] resources = console.nextLine().split(" ");
        int collcetionPaths = Integer.parseInt(console.nextLine());
        List<String> steps = new ArrayList<>();

        for (int i = 0; i < collcetionPaths; i++) {
             steps.add(console.nextLine());


        }












    }
}
