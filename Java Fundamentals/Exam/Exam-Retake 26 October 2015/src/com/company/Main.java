package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        List<String> strings = new ArrayList<>();
        int yourLifePoints = 5800;
        int demageASCI = 0;
        int glowcaps = 0;


        String input = "";

        while (!input.equals("Sporeggar")){
            input = console.nextLine();
            if (input.equals("Sporeggar"));
            else {
                strings.add(input);
            }
        }
        //For Damage
        for (String string : strings) {
            for (int i = 0; i < string.length()-1; i++) {
               demageASCI+= (int)string.charAt(i);
                if (string.charAt(i)== 'L'){
                    demageASCI-=276;
                }

            }
        }

        //For Glowcaps
        for (String string : strings) {
            glowcaps+= string.charAt(string.length()-1);
        }
        System.out.println(demageASCI);
        System.out.println(glowcaps);


    }
}
