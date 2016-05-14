package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by MartinLachev on 5/8/2016.
 */
public class Problem2 {
    public static void main(String[] args) {
        //Input
        Scanner console = new Scanner(System.in);
        int number = Integer.parseInt(console.nextLine());
        String input = "";
        List<String> list = new ArrayList<>();
        while (!input.equals("End")){
            input = console.nextLine();
            if (input.equals("End")){

            }else{
                list.add(input);
            }
        }

        System.out.println(list);

    }
}
