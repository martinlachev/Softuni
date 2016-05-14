package com.company;

import java.util.Scanner;

/**
 * Created by MartinLachev on 3/30/2016.
 */
public class Problem5CountAllWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();
        String[] words = text.split("([().,!?:;'\"-]|\\s)+");
        System.out.println();
        System.out.println(words.length);
    }

}


