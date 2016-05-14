package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by MartinLachev on 4/6/2016.
 */
public class Problem4CountAllWords {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String input = console.nextLine().replaceAll("[!?,]", "");

        int counter = 0;
        Pattern pattern = Pattern.compile("[^a-zA-Z']+");
        Matcher m = pattern.matcher(input);

        while (m.find()){counter++;};

        System.out.println(counter);
    }
}
