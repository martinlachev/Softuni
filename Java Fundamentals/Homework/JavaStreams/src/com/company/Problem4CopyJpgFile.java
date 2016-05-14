package com.company;


import java.awt.image.BufferedImage;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.IOException;
import javax.imageio.ImageIO;
import com.sun.org.apache.xerces.internal.impl.dv.util.Base64;

//Za da probwash da li raboti cukni run i w papkata imgFiles shte ti se poqwi dr file
public class Problem4CopyJpgFile {
    public static void main(String[] args) throws Exception {
        String dirName="src/com/company/imgFiles";
        ByteArrayOutputStream baos=new ByteArrayOutputStream(1000);
        BufferedImage img= ImageIO.read(new File(dirName,"img.jpg"));
        ImageIO.write(img, "jpg", baos);
        baos.flush();

        String base64String=Base64.encode(baos.toByteArray());
        baos.close();

        byte[] bytearray = Base64.decode(base64String);

        BufferedImage imag=ImageIO.read(new ByteArrayInputStream(bytearray));
        ImageIO.write(imag, "jpg", new File(dirName,"my-copied-picture.jpg"));

    }
}
