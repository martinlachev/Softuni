package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by MartinLachev on 3/30/2016.
 */
public class Problem8ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();
        Pattern emailPattern = Pattern
                .compile("[\\w-+]+(?:\\.[\\w-+]+)*@(?:[\\w-]+\\.)+[a-zA-Z]{2,7}");
        Matcher matcher = emailPattern.matcher(text);
        while (matcher.find()) {
            System.out.println(matcher.group());
        }
    }
}
