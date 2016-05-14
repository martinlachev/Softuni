package com.company;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;


/**
 * Created by MartinLachev on 3/23/2016.
 */
public class Problem11StarsEdnsCapitalletter {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        Pattern pat = Pattern.compile("\\b[A-Z]+[A-Za-z]*[A-Z]+\\b");
        Matcher match = pat.matcher(input);

        while(match.find()) {
            System.out.print(match.group() + " ");
        }

    }
}
