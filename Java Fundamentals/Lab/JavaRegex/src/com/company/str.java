package com.company;

public class str {

    public static void main(String[] args) {
        String allLngs = "C# , java; HTML, CSS";
        String [] arr = allLngs.split("[, ;]+");
        for (String s : arr) {
            System.out.println(s);
        }
    }
}
