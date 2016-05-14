import java.util.Scanner;

public class Problem12CharacterMultiplier {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String[] strArr = input.nextLine().split(" ");
        System.out.println(charMultiply(strArr[0], strArr[1]));
    }

    public static int charMultiply(String firstStr, String secondStr){
        int counter = firstStr.length();
        boolean equalLength = true;
        int sum = 0;

        if (firstStr.length() != secondStr.length()){
            equalLength = false;
            counter = Math.min(firstStr.length(), secondStr.length());
        }

        for (int i = 0; i < counter; i++){
            sum += firstStr.charAt(i) * secondStr.charAt(i);
        }

        if (!equalLength && counter == firstStr.length()){
            for (int i = counter; i < secondStr.length(); i++){
                sum += secondStr.charAt(i);
            }
        }
        else if (!equalLength){
            for (int i = counter; i < firstStr.length(); i++){
                sum += firstStr.charAt(i);
            }
        }
        return sum;
    }
}