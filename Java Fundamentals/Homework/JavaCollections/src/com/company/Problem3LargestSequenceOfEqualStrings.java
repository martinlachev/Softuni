package com.company;


import java.util.*;

/**
 * Created by MartinLachev on 3/30/2016.
 */
public class Problem3LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner console = new Scanner (System.in);
        String [] words = console.nextLine().split(" ");

        int largest =1,index =0, temp =1;

        for (int i = 1; i < words.length; i++) {
            if (words[i].equals(words[i-1])) {
                temp++;
            }else temp =1 ;

            if (temp>largest){
                largest = temp;
                index = i- largest +1;
            }

        }
        for (int i = 0; i < largest; i++) {
            System.out.print(words[index] + " ");

        }









    }

}
