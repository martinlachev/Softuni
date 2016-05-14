package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.function.Predicate;

public class Problem1FilterArray {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String [] arr = console.nextLine().split(" ");
        List<String> list = Arrays.asList(arr);
        Predicate<String> predicate = p -> p.length() > 3;

        list.stream().filter(predicate).forEach(e -> System.out.printf(e + " "));

    }

}
