package com.company;

import java.util.Scanner;

public class Problem1RectangleArea {

    public static void main(String[] args) {
	    Scanner console = new Scanner(System.in);

        int a = Integer.parseInt(console.nextLine());
        int b = Integer.parseInt(console.nextLine());
        System.out.println(rectangleArea(a,b));
    }
    public static int rectangleArea(int a, int b){
        return a*b;
    }
}
