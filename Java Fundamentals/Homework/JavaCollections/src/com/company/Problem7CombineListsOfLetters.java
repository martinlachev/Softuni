package com.company;

import java.util.Scanner;

/**
 * Created by MartinLachev on 3/30/2016.
 */
public class Problem7CombineListsOfLetters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine().toLowerCase();
        String subString = scanner.next().toLowerCase();
        int count = count(text, subString);
        System.out.println(count);
    }

    public static int count(final String string, final String substring) {
        int count = 0;
        int idx = 0;

        while ((idx = string.indexOf(substring, idx)) != -1) {
            idx++;
            count++;
        }

        return count;
    }
}
