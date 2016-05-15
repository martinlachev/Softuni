using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem
{
class BeerStock
{
    static void Main()
    {
        int amountOfReservedBeers = int.Parse(Console.ReadLine());
        string input;
        int result = 0;
        do
        {
           input = Console.ReadLine();
           result += StringSplitter(input);
           

        } while (input != "Exam Over" );
        
        if (result >= 100)
        {
            int resaultMinusOneHundred = result- (result / 100);
            if (resaultMinusOneHundred>amountOfReservedBeers)
            {
                int moreBeers = resaultMinusOneHundred - amountOfReservedBeers;
                //for cases
                int cases = moreBeers / 24;
                int leftOver = moreBeers % 24;
                //for sixpack
                int sixpack = leftOver / 6;
                //beers
                int beers = leftOver % 6;
                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.",cases,sixpack,beers);
            }
            else
            {
                int moreBeers = amountOfReservedBeers - resaultMinusOneHundred;
                //for cases
                int cases = moreBeers / 24;
                int leftOver = moreBeers % 24;
                //for sixpack
                int sixpack = leftOver / 6;
                //beers
                int beers = leftOver % 6;
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.",cases,sixpack,beers);
            }
        }
        else
        {
            if (result > amountOfReservedBeers)
            {
                int moreBeers = result - amountOfReservedBeers;
                //for cases
                int cases = moreBeers / 24;
                int leftOver = moreBeers % 24;
                //for sixpack
                int sixpack = leftOver / 6;
                //beers
                int beers = leftOver % 6;
                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", cases, sixpack, beers);
            }
            else
            {
                int moreBeers = amountOfReservedBeers - result;
                //for cases
                int cases = moreBeers / 24;
                int leftOver = moreBeers % 24;
                //for sixpack
                int sixpack = leftOver / 6;
                //beers
                int beers = leftOver % 6;
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", cases, sixpack, beers);
            }
        }
       
    }
    static int StringSplitter(string input)
    {
        int sum = 0;
        if (input == "Exam Over")
        {
            return sum += 0;
        }
        else
        {
            string[] split = input.Split(' ');
            int amount = int.Parse(split[0]);
            string type = split[1];

            if (type == "beers")
            {
                sum += amount;
            }
            else if (type == "cases")
            {
                sum = amount * 24;
            }
            else
            {
                sum = amount * 6;
            }

            return sum;
        }
       
        
       
    }
}
}
