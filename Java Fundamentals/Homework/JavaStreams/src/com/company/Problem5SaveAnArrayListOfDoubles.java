package com.company;


import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.ArrayList;
import java.util.List;

public class Problem5SaveAnArrayListOfDoubles  {
    public static void main(String[] args) throws Exception{
        ObjectOutputStream objectOutputStream = new ObjectOutputStream(new FileOutputStream("src/com/company/double.list"));


        List<Double> doubleList = new ArrayList<>();
        doubleList.add(3.4);
        doubleList.add(3.5);
        doubleList.add(3.6);
        doubleList.add(3.7);
        doubleList.add(3.8);

        for (Double aDouble : doubleList) {
            objectOutputStream.writeObject(doubleList);

        }
        objectOutputStream.close();





    }
}
