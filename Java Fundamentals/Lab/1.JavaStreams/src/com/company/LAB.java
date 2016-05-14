package com.company;

import java.beans.IntrospectionException;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;

/**
 * Created by MartinLachev on 3/21/2016.
 */
public class LAB {
    private static final String FILE_PATH = "D://users.txt";
    private static final String SAVE_PATH = "D://total-time.txt";


    public static void main(String[] args)throws IOException {
        File file = new File(FILE_PATH);

        BufferedReader reader = new BufferedReader(new FileReader(file));
        String line =reader.readLine();
            while (line!=null){
                line = reader.readLine();
                line = reader.readLine();
                line = reader.readLine();

            }
        String [] lineArgs = line.split(" ");
        String username = lineArgs[0];
        int totalMinutes =0;
        for (int i = 0; i < lineArgs.length; i++) {
            String[] loggedTime = lineArgs[i].split(":");
            int hours = Integer.parseInt(loggedTime[0]);
            int minutes = Integer.parseInt(loggedTime[1]);
            totalMinutes+=(hours*60)+ minutes;
            
        }

    }


}
