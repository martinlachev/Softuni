package com.company;

import java.util.HashSet;
import java.util.TreeSet;

/**
 * Created by MartinLachev on 3/23/2016.
 */
public class SetLiveDemo {
    public static void main(String[] args) {
        HashSet<String> set = new HashSet<>();
        set.add("pesho");
        set.add("Gosho");
        set.add("minka");
        for (String s : set) {
            System.out.println(s);
        }
        TreeSet<String> set2 = new TreeSet<>();
        set.add("pesho");
        set.add("Gosho");
        set.add("minka");
        for (String s : set) {
            System.out.println(s);
        }

    }

}
class Cat{
    public String breed;

    Cat c1 = new Cat();
   // c1.breed = "ulichna";


}
