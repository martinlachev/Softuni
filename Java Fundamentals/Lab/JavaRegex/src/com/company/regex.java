package com.company;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by MartinLachev on 3/30/2016.
 * use regex101.com
 */
public class regex {
    public static void main(String[] args) {
        String regex = "([A-Z])";
        Pattern patt = Pattern.compile(regex);
        Matcher matcher  = patt.matcher("AERFR456^&^&/n"+ "3456");

        while (matcher.find()){
            System.out.println("Group 1  " + matcher.group());
        }

    }
}
