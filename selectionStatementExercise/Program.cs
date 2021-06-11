using System;

namespace selectionStatementExercise
{
	class Program
	{

		static void Main(string[] args)
		{
			var r = new Random();
			var favNumber = r.Next(1, 1000);
			
			Console.WriteLine("What is my favorite number?");
			var userInput = int.Parse(Console.ReadLine());

			while(userInput != favNumber)
			{
				if (userInput > favNumber)
				{
					Console.WriteLine("That's too high! Try again!");
					userInput = int.Parse(Console.ReadLine());

				}
				else if (userInput < favNumber)
				{
					Console.WriteLine("That's too low! Try again!");
					userInput = int.Parse(Console.ReadLine());

				}
				else
				{
					Console.WriteLine("That's correct!");

				}
			}

			//if(userInput > favNumber)
			//{
			//	Console.WriteLine("That's too high! Try again!");


			//}
			//else if(userInput < favNumber)
			//{
			//	Console.WriteLine("That's too low! Try again!");

			//}
			//else
			//{
			//	Console.WriteLine("Nevermind");
			//}
		}
	}
}
