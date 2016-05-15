using System;

namespace Lab
{
class BiggestOfThree
{
	public static void Main ()
	{
			int firstNumber = int.Parse (Console.ReadLine ());
			int seconfNumber = int.Parse (Console.ReadLine ());
			int thirdNumber = int.Parse (Console.ReadLine ());


			if (firstNumber > seconfNumber && firstNumber > thirdNumber)
			{
				Console.WriteLine ("Max: " + firstNumber);
			}

			else if (seconfNumber>firstNumber && seconfNumber > thirdNumber) 
			{
				Console.WriteLine ("Max: " + seconfNumber);
			}

			else if (thirdNumber > firstNumber && thirdNumber > seconfNumber)
			{
				Console.WriteLine ("Max: " + thirdNumber);

			}
            
	}   
}
}
