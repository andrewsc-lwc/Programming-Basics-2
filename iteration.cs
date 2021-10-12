using System;

public class Iteration
{
	public Iteration()
	{
		int temp = 0;
		int totalTemp = 0;
		int numOfTemps = 0;
		while (temp != -100)
        {
			Console.WriteLine("Enter next temperature");
			temp = Convert.ToInt32(Console.ReadLine());
			totalTemp += temp;
			numOfTemps++;
		}
		int averageTemp = totalTemp / numOfTemps;
		Console.WriteLine(averageTemp);

		Console.WriteLine("Next attempt");

		temp = 0;
		totalTemp = 0;
		numOfTemps = 0;
		Console.WriteLine("Enter first temperature");
		temp = Convert.ToInt32(Console.ReadLine());
		while (temp != -100)
        {
			totalTemp += temp;
			numOfTemps++;
			Console.WriteLine("Enter next temperature");
			temp = Convert.ToInt32(Console.ReadLine());
		}
		averageTemp = totalTemp / numOfTemps;
		Console.WriteLine(averageTemp);

		temp = 0;
		totalTemp = 0;
		numOfTemps = 0;
		Console.WriteLine("Enter first temperature");
		temp = Convert.ToInt32(Console.ReadLine());
		while (temp != -100)
		{
			totalTemp += temp;
			numOfTemps++;
			Console.WriteLine("Enter next temperature");
			temp = Convert.ToInt32(Console.ReadLine());
		}
		if (numOfTemps > 0)
		{
			averageTemp = totalTemp / numOfTemps;
			Console.WriteLine(averageTemp);
		}
        else
        {
			Console.WriteLine("No values entered");
        }

		string z;
		do
		{
			Console.WriteLine("Sup, press n to stop");
			z = Console.ReadLine();
		} 
		while (z != "n");
	}
}
