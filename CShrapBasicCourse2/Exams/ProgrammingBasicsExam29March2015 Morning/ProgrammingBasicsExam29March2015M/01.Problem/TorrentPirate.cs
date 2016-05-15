using System;

namespace _15.ExamProblem
{
    class Program
    {
        static void Main()
        {
            int downloadData = int.Parse(Console.ReadLine());
            int costPerMovie = int.Parse(Console.ReadLine());
            int wifeMoneyPerHour = int.Parse(Console.ReadLine());
            decimal downloadSpeed = 2;
            decimal movieSize = 1500;
            string cinema = "cinema";
            string mall = "mall";

            decimal downloadTime = (((downloadData / downloadSpeed) / 60) / 60);
            decimal priceForDownload = Math.Round((downloadTime * wifeMoneyPerHour), 2);
            decimal numberOfMoviesDownloaded = downloadData / movieSize;
            decimal cinemaPrize = Math.Round((numberOfMoviesDownloaded * costPerMovie), 2);

            if (priceForDownload > cinemaPrize)
            {
                Console.WriteLine("{0} -> {1}lv", cinema, cinemaPrize);
            }
            else
            {
                Console.WriteLine("{0} -> {1}lv", mall, priceForDownload);
            }

        }
    }
}
