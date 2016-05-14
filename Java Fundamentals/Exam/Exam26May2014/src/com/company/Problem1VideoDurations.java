package com.company;





import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Problem1VideoDurations {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String input = "";
        String[]arr = new String[0];
        int minutes = 0;
        int hours = 0;
        while (!input.equals("End")){
            input = console.nextLine();
            if (input.equals("End")){input = "0";}
             arr = input.split(":");

        }
        List<Integer> list = new ArrayList<>();

        for (int i = 0; i < arr.length; i++) {
            list.add(Integer.parseInt(arr[i]));
        }
        for (Integer integer : list) {
            if (integer%2==0){
                minutes = minutes+integer ;
            }
            if (integer%2!=0){
                hours = hours+ integer;
            }
        }

        if (minutes>=59){
            int result = minutes/60;
            hours = hours + result;
            minutes = minutes - (result*60);
            System.out.println(minutes);
            System.out.println(hours);
        }
    }
}
