package com.company;

import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by MartinLachev on 3/21/2016.
 */
public class Streams {
    public static void main(String[] args) {

       try( BufferedReader br = new BufferedReader(
                new InputStreamReader(
                        new FileInputStream("text.txt.txt")));){
           System.out.println(br.readLine());
       }
           catch(IOException ex){

        }

    }
}
