using System;

namespace BMI_udregner
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Indtast din vægt i kg"); // takes the users input and stores it in the double weight
			double weight = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Indtast din højde i centimeter");// takes the users input and stores it in double height
			double height = Convert.ToDouble(Console.ReadLine());

			double BMI = (weight / (height * height)); // takes the users input and times the height and divide the weight

			if (BMI < 18.5)// if the users BMI is under 18.5 it will print out the text below
			{
				Console.WriteLine("Din BMI er " + BMI + " og du vejer for lidt");
			}
			else if (BMI == 25)// if the users BMI is 25 the line of code belwo gets executet 
			{
				Console.WriteLine("Din BMI er " + BMI + " og du vejer passende");
			}
			else if (BMI <= 30) //and if the users BMI is over 30 

			{
				Console.WriteLine("Din BMI er " + BMI + " OG Du er moderat overvægtige");
			}
			else //if none of the statments above is true the text below will get executet
			{
				Console.WriteLine("Fejl");
			}
			Console.ReadLine();
		}
	}  
	}

