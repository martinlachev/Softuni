package com.company;

import java.io.BufferedReader;
import java.io.FileReader;

public class Problem1Sumlines {

    public static void main(String[] args)throws Exception {
        //To read from a file
        FileReader file= new FileReader("src/com/company/txtFiles/lines.txt");
        BufferedReader reader = new BufferedReader(file);
        int sum =0;
        String str = "";
        String line = reader.readLine();
        while (line!=null){
            for (int i = 0; i < line.length(); i++) {
                int charReprisentation = line.charAt(i);
                sum += charReprisentation;



            }
            System.out.println(sum);
            sum=0;
            line = reader.readLine();


        }
        reader.close();


    }
}
