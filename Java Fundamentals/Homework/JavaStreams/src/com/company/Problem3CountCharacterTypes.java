package com.company;

import java.io.*;

public class Problem3CountCharacterTypes {
    public static void main(String[] args) throws Exception {
        FileReader fileReader = new FileReader("src/com/company/txtFiles/words.txt");
        BufferedReader bufferedReader = new BufferedReader(fileReader);
        FileWriter fileWriter = new FileWriter("src/com/company/txtFiles/count-char.txt");
        BufferedWriter bufferedWriter = new BufferedWriter(fileWriter);
        PrintWriter printWriter = new PrintWriter(System.out,true);

        int counterVowels = 0;
        int counterConsonants = 0;
        int counterPunktuation = 0;

        String line = bufferedReader.readLine();
        while (line != null){
            for (int i = 0; i < line.length(); i++) {
                if (line.charAt(i) == 'a'||
                        line.charAt(i) == 'e'||
                        line.charAt(i) == 'i'||
                        line.charAt(i) == 'o'||
                        line.charAt(i) == 'u'){
                    counterVowels ++;
                }
                else if (line.charAt(i) == '?'||
                        line.charAt(i) == '!'||
                        line.charAt(i) == '.'||
                        line.charAt(i) == ','){
                    counterPunktuation++;
                }
                else counterConsonants++;

            }
            bufferedWriter.write("Vowels: " + counterVowels + "\n" +
                    "Consonants: " + counterConsonants + "\n" +
                    "Punctuation:"  + counterPunktuation  );
            printWriter.printf("Vowels: " + counterVowels + "\n" +
                    "Consonants: " + counterConsonants + "\n" +
                    "Punctuation:"  + counterPunktuation );
            line = bufferedReader.readLine();
        }
        bufferedReader.close();
        bufferedWriter.close();
        printWriter.close();

    }
}
