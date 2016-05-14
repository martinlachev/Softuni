package com.company;

import java.util.Scanner;

/**
 * Created by MartinLachev on 3/30/2016.
 */
public class Problem6CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();
        String word = scanner.next();
        String[] words = text.split("([().,!?:;'\"-]|\\s)+");
        int count = 0;
        for (String currentWord : words) {
            if (currentWord.equalsIgnoreCase(word)) {
                count++;
            }
        }
        System.out.println(count);
    }
}
