package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner consoel = new Scanner(System.in);
        int numberDragonsAtStart = Integer.parseInt(consoel.nextLine());

        for (int i = 0; i < numberDragonsAtStart; i++) {
            int eggs = Integer.parseInt(consoel.nextLine());


        }

        int yearsHatcheryWorks = Integer.parseInt(consoel.nextLine());

        for (int i = 0; i < yearsHatcheryWorks; i++) {

            String yearType = consoel.nextLine();
        }

    }
}
class Dragon{
    private String name;
    private int age;
}
class Egg{
    private int age;
}
