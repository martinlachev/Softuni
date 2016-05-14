package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by MartinLachev on 4/6/2016.
 */
public class Problem2CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String text = console.nextLine().toLowerCase();
        String searchStr = console.nextLine().toLowerCase();

        int count = 0;
        int i = 0;

        while (text.indexOf(searchStr, i) != -1) {
            count++;
            i = text.indexOf(searchStr,i) + 1;
        }

        System.out.println(count);

    }

}
