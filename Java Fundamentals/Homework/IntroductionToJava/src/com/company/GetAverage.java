package com.company;

import java.math.BigDecimal;
import java.util.Scanner;

/**
 * Created by User on 10.3.2016 г..
 */
public class GetAverage {
    public static void main(String [] args){
        Scanner console = new Scanner(System.in);
        System.out.print("Enter a number for a:" );
        double a = Double.parseDouble(console.nextLine());
        System.out.print("Enter a number for b:" );
        double b = Double.parseDouble(console.nextLine());
        System.out.print("Enter a number for c:" );
        double c = Double.parseDouble(console.nextLine());
        System.out.printf("Result: %.2f",GetAvarge(a,b,c));
    }
    public static double GetAvarge(double a,double b,double c){

        return (a+b+c)/3;
    }
}

