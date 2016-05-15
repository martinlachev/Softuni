using System;

namespace marto
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter value for n: ");
            int n = int.Parse(Console.ReadLine());
            string message = Console.ReadLine();
            int[] arr = new int[message.Length];
            int blackTeam = 0;
            int whiteTeam = 0;


            for (int i = 0; i < message.Length; i++)
            {
                int asciiNumber = (int)message[i];
                if (asciiNumber >= 65 && asciiNumber <= 90 ||
                    asciiNumber >= 97 && asciiNumber <= 122 ||
                    asciiNumber >= 48 && asciiNumber <= 57)
                {
                    arr[i] = asciiNumber;
                }
                else
                {
                    arr[i] = 0;
                }

            }
            for (int i = 0; i < arr.Length; i += 2)
            {
                if (arr[i] >= 65 && arr[i] <= 90)
                {
                    whiteTeam += arr[i];
                }
                else
                {
                    blackTeam += arr[i];
                }
            }
            for (int j = 1; j <= arr.Length; j += 2)
            {
                if (arr[j] >= 65 && arr[j] <= 90)
                {
                    blackTeam += arr[j];
                }
                else
                {
                    whiteTeam += arr[j];
                }
            }
            if (blackTeam > whiteTeam)
            {
                int difference = blackTeam - whiteTeam;
                Console.WriteLine("The winner is: black team");
                Console.WriteLine(difference);

            }
            else if (whiteTeam > blackTeam)
            {
                int difference = whiteTeam - blackTeam;
                Console.WriteLine("The winner is: white team");
                Console.WriteLine(difference);
            }
            else if (whiteTeam == blackTeam)
            {
                Console.WriteLine("Equal result: " + whiteTeam);
            }


        }
    }
}
