package com.company;

import java.io.FileReader;
import java.io.IOException;
import java.io.Reader;
import java.util.InputMismatchException;
import java.util.Scanner;

public class TryCatchTrow {

    public static void main(String[] args) {
        //Ako ne muslovim try/catch/throw nqma da trugne(zdylvitelno try cathc block)
        //Reader reader = new FileReader("text.txt")

	    try {
            Scanner console = new Scanner(System.in);
            String [] arr = console.next().split("");

            int b = console.nextInt();
            console.nextLine();
            String str = console.nextLine();
            //Zada ne nigo podchertawa traqbwa da slowim Throw
            // neshto();

            int value = Integer.parseInt(str);
        }catch (InputMismatchException ime){
            System.out.println("Vuvel si greshno chislo pi4");
        }catch (NumberFormatException nfe){
            System.out.println("\"Vuvel si greshno chislo pi4\"");
        }finally {
            System.out.println("Finally block");
        }

    }
    public static void neshto ()throws IOException{
       // copyStream();
    }
    public static void copyStream()throws IOException{
        //Reader reader = new FileReader("text.txt");
    }
}
