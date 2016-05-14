package com.company;

import java.io.FileReader;
import java.io.Reader;

/**
 * Created by MartinLachev on 3/21/2016.
 */
public class TryWithResources {
    public static void main(String[] args) {
        //Zda se zatwori go prawim po tozi nachin
        try (Reader reader = new FileReader("text.txt")){

        }
        catch (Exception ex){

        }
        finally {

        }
    }
}
