package com.company;



import java.util.Scanner;

//
//area	=	|//
       // A	x 	 (	 B	y 	−	 C	y 	) 	+	 B	x 	 (	 C	y 	−	 A	y 	) 	+	 C	x 	 (	 A	y 	−	 B	y 	)//



public class Problem2TriangleArea {
    public static void main (String [] args){
        Scanner console = new Scanner (System.in);

        int aXcord = console.nextInt();
        int aYcord = console.nextInt();
        int bXcord = console.nextInt();
        int bYcord = console.nextInt();
        int cXcord = console.nextInt();
        int cYcord = console.nextInt();

        int formula = (aXcord*(bYcord-cYcord) + bXcord*(cYcord - aYcord) + cXcord*(aYcord - bYcord)) /2;

        System.out.println(Math.abs(formula));









    }



}
