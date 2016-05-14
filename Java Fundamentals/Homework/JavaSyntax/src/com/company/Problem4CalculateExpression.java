package com.company;

import java.util.Scanner;

/**
 * Created by MartinLachev on 3/16/2016.
 */
public class Problem4CalculateExpression {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        double a =console.nextDouble();
        double b =console.nextDouble();
        double c =console.nextFloat();

        double formulaOne;
        formulaOne = Math.pow(((Math.pow(a,2)+Math.pow(b,2))/ (Math.pow(a,2)-Math.pow(b,2))), (a+b+c) /Math.sqrt(c));
        double formulaTwo;
        formulaTwo = Math.pow((Math.pow(a,2)+ Math.pow(b,2)) - Math.pow(c,2),(a-b));


        System.out.printf("F1 result: %.2f; F2 formula: %.2f; Diff: %.2f",
                formulaOne,
                formulaTwo,
                differnceFormula(avarageFormula(formulaOne,formulaTwo),avargaFromThree(a,b,c) ));
    }
    public static double avarageFormula(double a,double b){

        return (a+b)/2;
    }
    public static double avargaFromThree(double a, double b, double c){

        return (a+b+c)/3;
    }
    public static double differnceFormula (double a ,double b){
        if (a>b) {
            return a-b;
        }
        else{
            return b-a;
        }

    }
}

