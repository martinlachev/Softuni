package com.company;

import java.io.*;

/**
 * Created by MartinLachev on 3/26/2016.
 */
public class Problem2ALLCAPITALS {
    public static void main(String[] args) throws Exception {

        FileReader file= new FileReader("src/com/company/txtFiles/lines.txt");
        BufferedReader buff = new BufferedReader(file);
        FileWriter fileWriter = new FileWriter("src/com/company/txtFiles/LinesProblem2.txt");
        BufferedWriter bufferedWriter = new BufferedWriter(fileWriter);
        PrintWriter pw = new PrintWriter(System.out,true);

        String line = buff.readLine();
        while(line!=null){
            line = line.toUpperCase()+ "\n";
            bufferedWriter.write(line);
            pw.printf(line);

            line = buff.readLine();


        }
        bufferedWriter.close();
        buff.close();
        pw.close();

    }
}
