package com.company;



import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;


public class Main {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        Set<String> set = new HashSet<>();
        String clubs = "";
        String spades = "";
        String diomnds = "";
        String hearts = "";

        int n = Integer.parseInt(console.nextLine());


        String input = "";
        for (int i = 0; i < n; i++) {
            input += console.nextLine();


        }

        regexChecker("[J+K+A+Q+10]+(s|d|h|c)", input, set);


        for (String s : set) {
            if (s.charAt(1) == 'c') {
                clubs = "Clubs";

            }
            if (s.charAt(1) == 'd') {
                diomnds = "Diamonds";

            }
            if (s.charAt(1) == 's') {
                spades = "Spades";

            }
            if (s.charAt(1) == 'h') {
                hearts = "Hearts";

            }
        }

        if (set.size() == 10) {
            System.out.println("Royal Flush Found - "+ spades);
            System.out.println("Royal Flush Found - "+ diomnds);
            System.out.printf("Royal's Royal Flushes - %d.", set.size()/5) ;
        }
        if (set.size() == 15) {
            System.out.println("Royal Flush Found - "+ spades);
            System.out.println("Royal Flush Found - "+ diomnds);
            System.out.println("Royal Flush Found - "+ spades);
            System.out.printf("Royal's Royal Flushes - %d.", set.size()/5) ;

        }
    }
    public static void regexChecker(String theRegex, String str2Check, Set<String> set){
        Pattern checkRegex = Pattern.compile(theRegex);

        Matcher regexMatcher = checkRegex.matcher(str2Check);

        while (regexMatcher.find()){
            if (regexMatcher.group().length()!=0){
                set.add(regexMatcher.group());
            }
        }
    }
}