package com.company;
import java.util.regex.*;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by MartinLachev on 3/23/2016.
 */
public class Problem10ExtractWords {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String input = console.nextLine();
        regexChecker("[A-Za-z]+",input);










    }
    public static void regexChecker(String input,String str2check){
        Pattern checkRegex = Pattern.compile(input);

        Matcher regexMatcher = checkRegex.matcher(str2check);

        while (regexMatcher.find()){
            System.out.println(regexMatcher.group(0)+" ");
        }
    }
}
