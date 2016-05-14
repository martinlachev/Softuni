package com.company;

import java.lang.reflect.Array;
import java.util.Arrays;

/**
 * Created by MartinLachev on 3/28/2016.
 */
public class Person {
    public static void main(String[] args) {
        String [] names = {"kut","dasda","dasdasd"};
        Arrays.stream(names).limit(1).forEach(System.out::println);
        Arrays.stream(names).map(name -> name + "Wilson").forEach(System.out::println);



    }

}
