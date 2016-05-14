package com.company;

import java.io.*;


/**
 * Created by MartinLachev on 3/21/2016.
 */
public class ReaderAndWriters {
    public static void main (String[] args)  {
       String [] array = new String [] {"Razni nesht","Stamat","Hristo"};
        try(BufferedWriter writer = new BufferedWriter(new FileWriter("out/production/pesho")) ){
            for (int i = 0; i < array.length; i++) {
                String s = array[i];
                writer.write(s + "\r\n");

            }
        }
        catch (IOException ghj){

        }
}
}
