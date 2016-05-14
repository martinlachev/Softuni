package com.company;


import java.util.*;


/**
 * Created by MartinLachev on 4/23/2016.
 */
public class Problem3 {
    public static void main(String[] args) {
        Scanner console  = new Scanner(System.in);
        String input = "";
        List<String> list = new ArrayList<>();
        List<int[]> listint = new ArrayList<>();
        List <Integer> listCriticalRatio = new ArrayList<>();
        int criricalRatio = 0 ;
        while (!input.equals("Break it.")){
            input = console.nextLine();
            if (!input.equals("Break it.") )
            list.add(input);
        }

        for (String s : list) {
            String [] arr = s.split(" ");
            int arr2 [] = new int [4];
            for (int i = 0; i < arr2.length; i++) {
                arr2[i] = Integer.parseInt(arr[i]);

            }
            listint.add(arr2);


        }
        for (int[] ints : listint) {
            for (int i = 0; i < ints.length; i++) {
                criricalRatio = Math.abs(((ints[2]+ints[3])-(ints[0]+ints[1])));

            }
            listCriticalRatio.add(criricalRatio);
        }








            Collections.sort(listCriticalRatio);
            int cRatioFinal = listCriticalRatio.get(listCriticalRatio.size() - 1);
            long breakpoint = (long) Math.pow(cRatioFinal, listint.size()) % listint.size();
            if (breakpoint>=0){
            for (int[] ints : listint) {
                System.out.print("Line: ");
                for (int i = 0; i < ints.length/4; i++) {
                    System.out.print("["+ ints[0] + ", "+ ints[1] + ", "+ints[2] + ", " + ints[3] + "]");


                }
                System.out.println();
            }
            System.out.println("Critical Breakpoint: "+ breakpoint);
            }


            else System.out.println("Critical breakpoint does not exist.");


    }
}

