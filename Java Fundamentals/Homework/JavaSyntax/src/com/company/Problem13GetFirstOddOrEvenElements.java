import java.util.Scanner;

public class Problem13GetFirstOddOrEvenElements {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String[] strArr = input.nextLine().split(" ");
        int n = Integer.parseInt(input.findInLine("\\d+"));
        String oddOrEven = input.next();
        int counter = 0;

        for (int i = 0; i < strArr.length; i++){
            String s = " ";
            if (counter == n){
                break;
            }
            if (counter == n - 1 || i == strArr.length - 1){
                s = "";
            }

            int currentNumber = Integer.parseInt(strArr[i]);
            if (currentNumber % 2 == 0 && oddOrEven.equals("even")){
                System.out.printf("%d%s", currentNumber, s);
                counter++;
            }
            else if (currentNumber % 2 != 0 && oddOrEven.equals("odd")){
                System.out.printf("%d%s", currentNumber, s);
                counter++;
            }
        }
    }
}