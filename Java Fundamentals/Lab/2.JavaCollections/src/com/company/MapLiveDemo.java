package com.company;

import java.util.HashMap;
import java.util.Map;

/**
 * Created by MartinLachev on 3/23/2016.
 */
public class MapLiveDemo {
    public static void main(String[] args) {
        HashMap<String,String> phones = new HashMap<>();

        phones.put("Pesho", "+345-887-333-222");
        phones.put("Gosho", "+345-887-333-111");
        phones.put("Pesho", "+345-887-333-333");

        System.out.println(phones.get("Pesho"));

        for (Map.Entry<String,String> pair : phones.entrySet()) {
            System.out.printf("%s -> %s%n",pair.getKey(),pair.getValue());
        }
    }
}
